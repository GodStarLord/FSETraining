using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class MovableAdapterImpl : IMovableAdapter
    {
        private readonly IMovable luxaryCars;

        public MovableAdapterImpl(IMovable luxaryCars)
        {
            this.luxaryCars = luxaryCars;
        }
        public double Speed()
        {
            return convertMPHtoKMPH(luxaryCars.Speed());
        }

        private double convertMPHtoKMPH(double speed)
        {
            return speed * 1.60934;
        }

        public double Price()
        {
            return PriceUSDtoEURO(luxaryCars.Price());
        }

        private double PriceUSDtoEURO(double price)
        {
            return price * 1.5;
        }
    }
}
