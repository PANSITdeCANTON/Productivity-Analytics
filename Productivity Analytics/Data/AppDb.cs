using Productivity_Analytics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Productivity_Analytics.Data
{
    public class AppDb : IdentityDbContext<Users>
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {

        }
    }
} 
