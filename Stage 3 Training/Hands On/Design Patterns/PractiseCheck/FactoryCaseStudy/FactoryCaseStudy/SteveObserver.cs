using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseStudy
{
    class SteveObserver : INotificationObserver
    {
        public string Name { get; set; }
        public void OnServerDown()
        {
            Console.WriteLine(Name + "'s notification received");
        }
    }
}
