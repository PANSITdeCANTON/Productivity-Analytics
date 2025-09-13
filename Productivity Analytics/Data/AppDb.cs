using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Productivity_Analytics.Models;

namespace Productivity_Analytics.Data
{
    public class AppDb : IdentityDbContext<Users, AppRole, int>
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {
        }
    }

}
