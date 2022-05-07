using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattrenSolution
{
    interface INotificationObserver
    {
        public int NumberOfTicketBooked { get; set; }
        public string Name { get; set; }
        void SendNotification();
    }
}
