using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingApp
{
    class Program
    {
        public async void FirstMethod()
        {
            Console.WriteLine("First Method Called\n");
            var result = await SecondMethod();

            Console.WriteLine(result);
        }

        public async Task<string> SecondMethod()
        {
            var result = await Task.Run(() =>
             {
                 Thread.Sleep(1000);
                 string str = "Second Method Called";
                 return str;
             });

            return result;
        }

        public void Caller()
        {
            FirstMethod();
            
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.Caller();


            Console.ReadLine();
        }
    }
}
