using System;

namespace FactoryCaseStudy
{
    public class LuxaryCar : Car
    {
        public LuxaryCar(CarType model, Location location) : base(CarType.LUXARY, location)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Connecting to Luxary Car");
            Console.WriteLine(base.ToString());
        }
    }
}