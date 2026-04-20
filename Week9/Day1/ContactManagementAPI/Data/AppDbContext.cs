using ContactManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<UserInfo> Users => Set<UserInfo>();
    }
}