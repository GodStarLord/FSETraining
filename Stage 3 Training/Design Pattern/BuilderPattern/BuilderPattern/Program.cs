using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuildCompany builder = new CompanyBuilder();

            CompanyDirector director = new CompanyDirector();

            director.Construct(builder);

            MyCompany company = builder.GetCompany();

            Console.ReadLine();
        }
    }
}
