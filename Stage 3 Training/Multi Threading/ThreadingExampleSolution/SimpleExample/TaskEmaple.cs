using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    class TaskEmaple
    {
        static void Main(string[] args)
        {
            Task<string> sampleTask = Task.Run(() => "Hello");

            Console.WriteLine(sampleTask.Result);

            Console.ReadLine();
        }
    }
}
