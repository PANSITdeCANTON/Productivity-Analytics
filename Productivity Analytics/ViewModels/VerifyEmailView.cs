using System.ComponentModel.DataAnnotations;

namespace Productivity_Analytics.ViewModels
{
    public class VerifyEmailView
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public required string Email { get; set; }
    }
}
