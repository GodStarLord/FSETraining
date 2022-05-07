using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattrenSolution
{
    class SMSObserver : INotificationObserver
    {
        string name;
        public SMSObserver(string name)
        {
            this.name = name;
        }
        static int count = 1;
        public int NumberOfTicketBooked { get => count; set => ++count; }
        public string Name { get => name; set => name=value; }

        public void SendNotification()
        {
            Console.WriteLine("ticket number {0} has been booked successfully for {1}", NumberOfTicketBooked,Name);
            ++NumberOfTicketBooked;
        }
    }
}
