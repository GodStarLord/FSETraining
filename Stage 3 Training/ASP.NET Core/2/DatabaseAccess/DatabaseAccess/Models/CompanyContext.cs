using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() //Create Default constructor for mocking
        {
            
        }
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) //Injecting Options
        {
            
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual  string Checks { get; set; }     //SimpleMOQ

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Department>().ToTable("Department");
        }
    }
}