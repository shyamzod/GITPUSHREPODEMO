using System.ComponentModel.DataAnnotations;

namespace TaskManagerProject.Models
{
    public class LoginModel
    {
        // Property for the username or email
        [Required]
        [Display(Name = "Username")]
        public string? Username { get; set; }
        // Property for the password
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }
        // Optional property for remember me functionality
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
        public string? Role { get; set; }
    }
}
