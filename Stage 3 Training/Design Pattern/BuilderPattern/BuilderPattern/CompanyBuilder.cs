using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CompanyBuilder : IBuildCompany
    {
        private MyCompany company = new MyCompany();

        public void BuildBuilding()
        {
            company.Building = "Building Done";
            Console.WriteLine("Building Done");
        }

        public void BuildCustomerBase()
        {
            company.Client = "Customer Base Done";
            Console.WriteLine("Customer Base Done");
        }

        public MyCompany GetCompany()
        {
            return company;
        }
    }
}
