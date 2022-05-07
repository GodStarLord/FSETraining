using System;

namespace ObserverPattrenSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationObserver notificationObserver = new SMSObserver("Kishan");
            INotificationService notificationService = new NotificationService();

            notificationObserver.SendNotification();
            notificationObserver.SendNotification();

            INotificationObserver notificationObserver1 = new SMSObserver("Kumar");
            notificationObserver1.SendNotification();
            notificationObserver1.SendNotification();
            
            notificationService.AddSubscriber(notificationObserver);
            notificationService.AddSubscriber(notificationObserver1);
            notificationService.NotifySubscriber();
            notificationService.RemoveSubscriber(notificationObserver1);
            
            Console.ReadKey();
        }
    }
}
