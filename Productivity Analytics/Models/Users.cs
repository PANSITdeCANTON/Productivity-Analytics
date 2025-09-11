using Microsoft.AspNetCore.Identity;

namespace Productivity_Analytics.Models
{
    public class Users : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
