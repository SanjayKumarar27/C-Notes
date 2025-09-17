
//using ASPCoreMVCEntityLINQ.Models;
using CoreFirstEmp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEmp.Controllers
{
    [Authorize(Roles = "Admin")]
    [ValidateAntiForgeryToken]
    public class AdminController : Controller

    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.ToList();  // Get all users
            var userRoles = new List<UserRoleViewModel>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);  // Get roles for each user
                userRoles.Add(new UserRoleViewModel
                {
                    UserId = user.Id,  // User's unique ID
                    UserName = user.UserName,  // Username
                    Roles = roles  // List of roles the user has
                });
            }

            return View(userRoles);  // Pass the list of users and their roles to the view
        }

        // POST: Admin/AssignRole
        [HttpPost]
        public async Task<IActionResult> AssignRole(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null && !string.IsNullOrEmpty(roleName))
            {
                // First, get the current roles of the user
                var currentRoles = await _userManager.GetRolesAsync(user);

                // Remove all current roles before assigning the new one
                foreach (var role in currentRoles)
                {
                    await _userManager.RemoveFromRoleAsync(user, role);
                }

                // Add the new role (either Admin or User)
                var roleExist = await _roleManager.RoleExistsAsync(roleName);
                if (roleExist)
                {
                    await _userManager.AddToRoleAsync(user, roleName);
                }
            }

            return RedirectToAction(nameof(Index));  // Redirect back to the list of users
        }

    }
}
