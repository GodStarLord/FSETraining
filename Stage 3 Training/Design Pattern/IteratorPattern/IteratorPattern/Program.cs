using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AggregateChild aggregateChild = new AggregateChild();

            aggregateChild[0] = "Element 1";
            aggregateChild[0] = "Element 2";
            aggregateChild[0] = "Element 3";

            MyIterator iterator = aggregateChild.CreateIterator();

            object fi = iterator.First();

            while (fi!=null)
            {
                Console.WriteLine(fi);
                fi = iterator.Next();
            }


            Console.ReadLine();
        }
    }
}
