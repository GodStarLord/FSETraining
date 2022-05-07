using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseStudy
{
    public interface INotificationObserver
    {
        string Name { get; set; }
        void OnServerDown();
    }
}
