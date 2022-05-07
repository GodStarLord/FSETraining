using System;
using System.Runtime.CompilerServices;

namespace FactoryCaseStudy
{
    public class CarClient : CarFactory
    {
        private CarFactory carFactory;
        private Car _car;

        public CarClient(CarFactory carFactory)
        {
            this.carFactory = carFactory;
        }

        public void BuildMicroCar(Location location)
        {
            _car = new MicroCar(CarType.MICRO, location);
        }

        public void BuildMiniCar(Location location)
        {
            _car = new MiniCar(CarType.MINI, location);
        }

        public void BuildLuxaryCar(Location location)
        {
            _car = new LuxaryCar(CarType.LUXARY, location);
        }
    }
}