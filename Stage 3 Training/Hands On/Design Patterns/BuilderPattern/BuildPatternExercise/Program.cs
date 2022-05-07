using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Builder builder = new AdultPackage();
            shop.Construct(builder);
            builder.SweetShop.Show();

            builder = new ChildPackage();
            shop.Construct(builder);
            builder.SweetShop.Show();

            Console.ReadLine();
        }
    }
}
