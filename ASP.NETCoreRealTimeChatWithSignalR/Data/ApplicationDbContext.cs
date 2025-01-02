using ASP.NETCoreRealTimeChatWithSignalR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreRealTimeChatWithSignalR.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Message> Messages { get; set; }

    }
}
