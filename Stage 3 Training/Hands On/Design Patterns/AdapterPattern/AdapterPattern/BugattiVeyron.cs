using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class BugattiVeyron : IMovable
    {
        public double Speed()
        {
            return 258;
        }

        public double Price()
        {
            return 2300;
        }
    }
}
