using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuildCompany
    {
        void BuildBuilding();
        void BuildCustomerBase();

        MyCompany GetCompany();
    } 
}
