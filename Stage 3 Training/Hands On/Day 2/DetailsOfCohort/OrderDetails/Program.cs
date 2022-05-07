using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetails
{
    class Program
    {
        public static void OrderDetails(string sellerName, string productName, [Optional]int orderQuantity , bool isReturnable = true )
        {
            Console.WriteLine($"Here is the order detail – {orderQuantity} " +
                              $"number of {productName} by {sellerName} is ordered. " +
                              $"It’s returnable status is {isReturnable}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Seller Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product name");
            string productName = Console.ReadLine();

            OrderDetails(name, productName, 50);

            Console.ReadLine();
        }
    }
}
