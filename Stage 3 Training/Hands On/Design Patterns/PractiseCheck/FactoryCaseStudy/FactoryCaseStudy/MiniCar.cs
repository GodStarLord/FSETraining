using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseStudy
{
    class MiniCar : Car
    {
        public MiniCar(CarType model, Location location) : base(CarType.MINI, location)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Connecting to Mini Car");
            Console.WriteLine(base.ToString());
        }
    }
}
