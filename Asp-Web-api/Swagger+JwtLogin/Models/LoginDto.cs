using System.ComponentModel.DataAnnotations;

namespace Swagger_JwtLogin.Models
{
    public class LoginDto
    {
        [Required,EmailAddress]
        public string Email { get; set; }

        [Required,MaxLength(20)]
        public string Password { get; set; }
    }
}
