using System;

namespace DesignPattrenFinalCheckProject
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdersFactory ordersFactory = new ConcreteOrders();
            Client client = new Client(ordersFactory);

            client.BuildElectronic(Channel.EcommerceWebsite);
            client.BuildFurniture(Channel.TeleCaller);
            client.BuildToys(Channel.EcommerceWebsite);
            
            Console.ReadKey();
        }
    }
    public enum ProductType
    {
        ElectronicProduct,Toys,Furniture
    }
    public enum Channel
    {
        EcommerceWebsite,TeleCaller
    }
}
