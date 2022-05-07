using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleExample
{
    class Program
    {
        void PrintTo100()
        {
            for (int i = 10; i <= 101; i = i + 10)
            {
                lock (this)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($"Thread is {Thread.CurrentThread.Name} : {i}\n");
                }
            }
        }

         void PrintTo1000()
        {
            for (int i = 100; i <= 1001; i = i + 100)
            {
                
                lock (this)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($"Thread is {Thread.CurrentThread.Name} : {i}\n");
                }
                
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            //This prints one after another
            //PrintTo100();
            //PrintTo1000();

            //Using Multi threading
            //These threads are independent of each other
            Thread t1 = new Thread(program.PrintTo100)
            {
                Name = "Thread 1"
            };

            Thread t2 = new Thread(program.PrintTo1000)
            {
                Name = "Thread 2"
            };

            t1.Start(); //Starts the thread
            t1.Join();
            t2.Start();

            Console.ReadLine();
        }
    }
}
