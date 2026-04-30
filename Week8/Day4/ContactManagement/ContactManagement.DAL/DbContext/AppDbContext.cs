using ContactManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.DAL.DbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ContactInfo> Contacts => Set<ContactInfo>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<UserInfo> Users => Set<UserInfo>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContactInfo>()
                .HasOne(c => c.Company)
                .WithMany(cmp => cmp.Contacts)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ContactInfo>()
                .HasOne(c => c.Department)
                .WithMany(dep => dep.Contacts)
                .HasForeignKey(c => c.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserInfo>()
                .HasIndex(u => u.EmailId)
                .IsUnique();

            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyId = 1, CompanyName = "ABC Infotech" },
                new Company { CompanyId = 2, CompanyName = "TechNova" }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" },
                new Department { DepartmentId = 2, DepartmentName = "HR" }
            );

            modelBuilder.Entity<ContactInfo>().HasData(
                new ContactInfo
                {
                    ContactId = 1,
                    FirstName = "Rahul",
                    LastName = "Sharma",
                    EmailId = "rahul@example.com",
                    MobileNo = 9876543210,
                    Designation = "Developer",
                    CompanyId = 1,
                    DepartmentId = 1
                },
                new ContactInfo
                {
                    ContactId = 2,
                    FirstName = "Aisha",
                    LastName = "Khan",
                    EmailId = "aisha@example.com",
                    MobileNo = 9123456780,
                    Designation = "HR Executive",
                    CompanyId = 2,
                    DepartmentId = 2
                }
            );
        }
    }
}
