using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CompanyDirector
    {
        public void Construct(IBuildCompany build)
        {
            build.BuildBuilding();
            build.BuildCustomerBase();
        }
    }
}
