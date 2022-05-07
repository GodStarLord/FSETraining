using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOne
{
    class Employee : IComparable<Employee>
    {
        int id, age;
        string name;
        double salary;

        public Employee()
        {
        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public void TakeEmployeeDetailsFromUser()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary;
        }

        public int CompareTo(Employee other)
        {
            Employee emp = (Employee) other;

            int iSalComaprison = emp.salary.CompareTo(other.salary);
            
            if (iSalComaprison == 0) //Salaries are equal use name as comparison criteria
            {
                //lhs name comparison with rhs name
                return name.CompareTo(other.name);
            }
            //Now if salaries are not equal, return comparison of salries
            return iSalComaprison;
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
