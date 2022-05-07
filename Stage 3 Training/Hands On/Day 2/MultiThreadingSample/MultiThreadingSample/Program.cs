using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingSample
{
    class Program
    {
        static void PrintTheNumbers(object state)
        {
            Printer task = (Printer) state;
            task.PrintNumbers();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("****Multithreading Program****");

            Console.WriteLine($"Main thread stated. ThreadID - {Thread.CurrentThread.ManagedThreadId}");

            Printer p = new Printer();

            WaitCallback workItem = new WaitCallback(PrintTheNumbers);

            //Queue the method 10 times
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }

            Console.WriteLine("All task queued");
            Console.ReadLine();
        }
    }
}
