using System;

namespace FactoryCaseStudy
{
    public class MicroCar : Car
    {
        public MicroCar(CarType model, Location location) : base(CarType.MICRO, location)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Connecting to Micro Car");
            Console.WriteLine(base.ToString());
        }
    }
}