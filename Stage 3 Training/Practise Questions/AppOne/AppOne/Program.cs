using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Easy
            //List<string> employeeNameList = new List<string>();
            //EmoloyeePromotion employeePromotion = new EmoloyeePromotion();
            //employeePromotion.EmployeeInput(employeeNameList);
            //Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion");
            //string empToFind = Console.ReadLine();
            //employeePromotion.EmployeePositionForPromotion(employeeNameList, empToFind);
            //employeePromotion.EmployeePromted(employeeNameList);
            //Console.ReadLine();

            //Medium
            Dictionary<int, Employee> empDictionary = new Dictionary<int, Employee>();
            List<Employee> empList = new List<Employee>();

            Console.WriteLine("Enter the number of employee's data to store");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Employee emp = new Employee();
                emp.TakeEmployeeDetailsFromUser();

                empDictionary.Add(emp.Id, emp);
                empList.Add(emp);
            }

            Console.WriteLine("Enter the Emp Id to find get the details");
            int id = int.Parse(Console.ReadLine());

            //using Dictionary
            Console.WriteLine(empDictionary[id]);
            //using List
            Console.WriteLine();
            var result = empList.Where(x => x.Id == id);
            Console.WriteLine(result);
            Console.WriteLine();

            //Sort based on Emp Salary
            empList.Sort();
            Console.WriteLine("\nEmployee sorted based on their salary\n");
            foreach (Employee employee in empList)
            {
                Console.WriteLine(employee);
            }

            //Find All Employee with the given name
            Console.WriteLine("Enter the employee Name to find");
            string name = Console.ReadLine();
            var resultName = empList.Where(x => x.Name == name);

            foreach (Employee employee in resultName)
            {
                Console.WriteLine();
                Console.WriteLine(employee);
            }

            //Employee older than given employee
            Console.WriteLine("Enter the Employee Id to find employees older than the given");
            var empOnId = empList.Where(x => x.Id == id).Single();

            var empOlderThanGiven = empList.Where(x => x.Age > empOnId.Age);
            Console.WriteLine("Employees older than the given employee");
            foreach (Employee employee in empOlderThanGiven)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
