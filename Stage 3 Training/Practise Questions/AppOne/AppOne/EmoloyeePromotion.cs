using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOne
{
    class EmoloyeePromotion
    {
        public void EmployeeInput(List<string> employeeName)
        {
            string name = "";
            Console.WriteLine("Please enter the employee names in the order of their eligibility" +
                              " for promotion(Please enter blank to stop)");

            do
            {
                name = Console.ReadLine();
                if (name != null)
                {
                    employeeName.Add(name);
                }
            } while (name != "");
        }

        public void EmployeePositionForPromotion(List<string> employeeName, string empToFind)
        {
            int res = employeeName.IndexOf(empToFind);

            Console.WriteLine($"\"{empToFind}\" is the the position {res + 1} for promotion.");
        }

        public void EmployeePromted(List<string> empList)
        {
            Console.WriteLine("\nPromoted employee list:");
            empList.Sort();

            foreach (var value in empList)
            {
                Console.WriteLine($"{value}");
            }
        }
    }
}
