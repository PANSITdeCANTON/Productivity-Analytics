using System.ComponentModel.DataAnnotations;

namespace Productivity_Analytics.ViewModels
{
    public class LoginView
    {
        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
