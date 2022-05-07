using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattrenSolution
{
    interface INotificationService
    {
        void AddSubscriber(INotificationObserver notificationObserver);
        void RemoveSubscriber(INotificationObserver notificationObserver);
        void NotifySubscriber();
    }
}
