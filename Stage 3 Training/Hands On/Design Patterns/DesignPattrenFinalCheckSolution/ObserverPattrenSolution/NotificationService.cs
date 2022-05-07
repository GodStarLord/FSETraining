using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattrenSolution
{
    class NotificationService : INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();
        public void AddSubscriber(INotificationObserver notificationObserver)
        {
            observers.Add(notificationObserver);
            foreach(var s in observers)
            {
                Console.WriteLine(s.Name);
            }
        }

        public void NotifySubscriber()
        {
            foreach(var s in observers)
            {
                Console.WriteLine("{0} Subscribed Successfully", s.Name);
            }
        }

        public void RemoveSubscriber(INotificationObserver notificationObserver)
        {
            observers.Remove(notificationObserver);
            foreach (var s in observers)
            {
                Console.WriteLine(s.Name);
            }

        }
    }
}
