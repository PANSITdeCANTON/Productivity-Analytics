using Microsoft.AspNetCore.Identity;

namespace Productivity_Analytics.Models
{
    public class Users : IdentityUser<int>
    {
        public string FullName { get; set; }
    }
    public class AppRole : IdentityRole<int>
    {
    }
}
