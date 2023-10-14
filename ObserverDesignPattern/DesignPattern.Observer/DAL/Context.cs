using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-UB012MD\\SQLEXPRESS;initial catalog=DesignPattern3;integrated security=true;");
        }
        public DbSet<WelcomeMessage> welcomeMessages { get; set; }
        public DbSet<UserProcess> userProcesses { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
