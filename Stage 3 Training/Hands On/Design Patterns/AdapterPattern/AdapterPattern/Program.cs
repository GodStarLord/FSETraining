using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable luxaryCar = new BugattiVeyron();
            IMovableAdapter adapter = new MovableAdapterImpl(luxaryCar);

            var speed = adapter.Speed();
            Console.WriteLine($"The Speed of the car is {speed} KMPH");

            var price = adapter.Price();
            Console.WriteLine($"The price of the car in EURO is {price}");

            Console.ReadLine();
        }
    }
}
