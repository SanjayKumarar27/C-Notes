
using System.ComponentModel.DataAnnotations;

namespace CoreFirstEmp.Models
{
    public class UserRoleViewModel
    {
        [Key]
        public string UserId { get; set; }  // User's unique ID
        public string? UserName { get; set; }  // User's name
        public IList<string> Roles { get; set; }  // List of roles assigned to the user
    }
}
