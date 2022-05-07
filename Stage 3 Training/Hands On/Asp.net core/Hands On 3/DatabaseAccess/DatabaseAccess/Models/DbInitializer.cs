using System.Linq;

namespace DatabaseAccess.Models
{
    public class DbInitializer
    {
        public static void Initialize(CompanyContext context)
        {
            context.Database.EnsureCreated();
            if(context.Employees.Any()) return;

            var department = new Department[]
            {
                new Department {Name = "Admin"},
                new Department {Name = "IT"},
            };
            
            foreach (var dept in department)
            {
                context.Departments.Add(dept);
            }

            context.SaveChanges();

            var employee = new Employee[]
            {
                new Employee { Name = "Ramu", Age = 21, DepartmentId = 1 },
                new Employee { Name = "Somu", Age = 21, DepartmentId = 1 } 
            };

            foreach (var emp in employee)
            {
                context.Employees.Add(emp);
            }

            context.SaveChanges();
        }
    }
}