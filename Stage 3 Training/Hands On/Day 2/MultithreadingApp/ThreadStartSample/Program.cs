using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****ThreadStart Delegate App****");
            Console.WriteLine("Do you want 1 or 2 threads?");
            string threadCount = Console.ReadLine();

            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary Thread";

            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing Main() ");

            Printer printer = new Printer();

            switch (threadCount)
            {
                case "2":
                    Thread backgroundThread = new Thread(new ThreadStart(printer.PrintNumbers));
                    backgroundThread.Name = "Secondary Thread";
                    backgroundThread.Start();
                    break;

                case "1":
                    printer.PrintNumbers();
                    break;
                    
                default:
                    Console.WriteLine("You get 1 Thread");
                    goto case "1";
            }

            Console.WriteLine("Hello from Main()");
        }
    }
}
