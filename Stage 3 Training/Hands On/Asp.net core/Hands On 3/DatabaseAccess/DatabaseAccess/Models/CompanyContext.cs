using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) //Injecting Options
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Department>().ToTable("Department");
        }
    }
}