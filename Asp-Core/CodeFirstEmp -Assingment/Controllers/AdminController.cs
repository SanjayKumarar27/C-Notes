//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace CodeFirstEmp.Controllers
//{
//    public class RoleAssignmentController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEmp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleAssignmentController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleAssignmentController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: RoleAssignment
        public async Task<IActionResult> Index()
        {
            var model = new RoleAssignmentViewModel();

            // Get all users
            var users = await _userManager.Users.ToListAsync();
            model.Users = users.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.Email ?? u.UserName
            }).ToList();

            // Get all roles
            var roles = await _roleManager.Roles.ToListAsync();
            model.Roles = roles.Select(r => new SelectListItem
            {
                Value = r.Name,
                Text = r.Name
            }).ToList();

            return View(model);
        }

        // POST: RoleAssignment/AssignRole
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignRole(string userId, string roleName)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(roleName))
            {
                TempData["Error"] = "Please select both a user and a role.";
                return RedirectToAction(nameof(Index));
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction(nameof(Index));
            }

            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                TempData["Error"] = "Role does not exist.";
                return RedirectToAction(nameof(Index));
            }

            // Check if user is already in the role
            var isInRole = await _userManager.IsInRoleAsync(user, roleName);
            if (isInRole)
            {
                TempData["Warning"] = $"User {user.Email ?? user.UserName} is already in the {roleName} role.";
                return RedirectToAction(nameof(Index));
            }

            var result = await _userManager.AddToRoleAsync(user, roleName);
            if (result.Succeeded)
            {
                TempData["Success"] = $"Successfully assigned {roleName} role to {user.Email ?? user.UserName}.";
            }
            else
            {
                TempData["Error"] = $"Failed to assign role: {string.Join(", ", result.Errors.Select(e => e.Description))}";
            }

            return RedirectToAction(nameof(Index));
        }

        // POST: RoleAssignment/RemoveRole
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveRole(string userId, string roleName)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(roleName))
            {
                TempData["Error"] = "Please select both a user and a role.";
                return RedirectToAction(nameof(Index));
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction(nameof(Index));
            }

            var isInRole = await _userManager.IsInRoleAsync(user, roleName);
            if (!isInRole)
            {
                TempData["Warning"] = $"User {user.Email ?? user.UserName} is not in the {roleName} role.";
                return RedirectToAction(nameof(Index));
            }

            var result = await _userManager.RemoveFromRoleAsync(user, roleName);
            if (result.Succeeded)
            {
                TempData["Success"] = $"Successfully removed {roleName} role from {user.Email ?? user.UserName}.";
            }
            else
            {
                TempData["Error"] = $"Failed to remove role: {string.Join(", ", result.Errors.Select(e => e.Description))}";
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: RoleAssignment/GetUserRoles
        [HttpGet]
        public async Task<IActionResult> GetUserRoles(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return Json(new { success = false, message = "Invalid user ID" });
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return Json(new { success = false, message = "User not found" });
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            return Json(new { success = true, roles = userRoles });
        }
    }

    public class RoleAssignmentViewModel
    {
        public List<SelectListItem> Users { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Roles { get; set; } = new List<SelectListItem>();
        public string SelectedUserId { get; set; }
        public string SelectedRole { get; set; }
    }
}