using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseStudy
{
    public class NotificationService : INotificationService
    {
        private readonly List<INotificationObserver> _list = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver observer)
        {
            _list.Add(observer);

            foreach (var item in _list)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("");
        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            _list.Remove(observer);

            foreach (var item in _list)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("");
        }

        public void NotifySubscriber()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item.Name);
                item.OnServerDown();
            }

            Console.WriteLine("");
        }
    }
}
