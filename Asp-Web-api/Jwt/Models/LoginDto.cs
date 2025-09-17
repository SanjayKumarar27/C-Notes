using System.ComponentModel.DataAnnotations;

namespace https_Codefirst.Models
{
    public class LoginDto
    {
        [Required,EmailAddress]
        public string Email { get; set; }

        [Required,MaxLength(20)]
        public string Password { get; set; }
    }
}
