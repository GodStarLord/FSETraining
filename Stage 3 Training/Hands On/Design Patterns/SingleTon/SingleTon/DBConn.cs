using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class DBConn
    {
        private static DBConn _instance = null;

        public static DBConn GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConn();
                Console.WriteLine("New Instance Created");
            }
            else
                Console.WriteLine("Instance Already Created");

            return _instance;
        }

        private DBConn()
        {

        }
    }
}
