using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Factory Pattern
            //Console.WriteLine("*****Abstract Factory Pattern*****\n");

            //CarFactory carFactory = new ConcreteCarFactory();
            //CarClient carClient = new CarClient(carFactory); 
            //carClient.BuildMicroCar(Location.USA);
            //carClient.BuildMiniCar(Location.INDIA);
            //carClient.BuildLuxaryCar(Location.DEFAULT);

            //Console.WriteLine("\n-----------------------------\n");

            ////Observer Pattern
            //Console.WriteLine("*****Observer Pattern*****\n");
            //INotificationObserver johnObserver = new JohnObserver();
            //INotificationObserver steveObserver = new SteveObserver();
            //INotificationService service = new NotificationService();

            //johnObserver.Name = "John Observer";
            //steveObserver.Name = "Steve Observer";

            //service.AddSubscriber(johnObserver);
            //service.AddSubscriber(steveObserver);

            //service.NotifySubscriber();

            //service.RemoveSubscriber(steveObserver);

            //Console.WriteLine("\n-----------------------------\n");

            //Console.ReadLine();
            int[] arr = {3, 5, 2, 4, 6, 8};
            Console.WriteLine($"{minimumSwaps(arr)}");
        }

        static int minimumSwaps(int[] a)
        {
            int swap = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                if (i + 1 != a[i])
                {
                    int t = i;
                    while (a[t] != i + 1)
                    {
                        t++;
                    }
                    int temp = a[t];
                    a[t] = a[i];
                    a[i] = temp;
                    swap++;
                }
            }
            return swap;

        }
    }
}
