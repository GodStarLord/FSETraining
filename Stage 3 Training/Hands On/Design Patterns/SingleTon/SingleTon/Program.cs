using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn instance = DBConn.GetInstance(); //new instance
            DBConn newInstance = DBConn.GetInstance(); //instance already created

            Console.ReadLine();
        }
    }
}
