using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingSample
{
    class Printer
    {
        private object lockToken = new object();

        public void PrintNumbers()
        {
            lock (lockToken)
            {
                Console.WriteLine($"Tread -> {Thread.CurrentThread.ManagedThreadId} started " +
                                  $"{DateTime.Now.ToLongTimeString()} " +
                                  $"and executing PrimeNumbers()");

                Console.WriteLine("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{i}, ");
                    Thread.Sleep(1000);
                }

                Console.WriteLine();
            }
        }
    }
}
