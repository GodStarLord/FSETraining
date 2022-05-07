using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPatternExercise
{
    class AdultPackage : Builder
    {
        public AdultPackage()
        {
            SweetShop = new SweetShop("AdultPackage");
        }
        public override void NoOfSavory()
        {
            SweetShop["savory"] = 2;
        }

        public override void NoOfSweets()
        {
            SweetShop["sweet"] = 3;
        }
    }
}
