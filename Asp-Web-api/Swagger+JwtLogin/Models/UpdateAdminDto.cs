using System.ComponentModel.DataAnnotations;

namespace Swagger_JwtLogin.Models
{
    public class UpdateAdminDto
    {
        [Required,EmailAddress]

        public string Email { get; set; }

        [Required]
        public string Role { get; set; }    
    }
}
