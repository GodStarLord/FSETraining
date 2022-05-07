using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattrenFinalCheckProject
{
    class ElectronicOrder : Order
    {
        public ElectronicOrder(ProductType productType,Channel channel):base(ProductType.ElectronicProduct,channel)
        {
            ProcessOrder(); 
        }
        public override void ProcessOrder()
        {
            Console.WriteLine("getting Electronic Order");
            Console.WriteLine(base.ToString());
        }
    }
    class ToysOrder : Order
    {
        public ToysOrder(ProductType productType, Channel channel) : base(ProductType.Toys, channel)
        {
            ProcessOrder();
        }
        public override void ProcessOrder()
        {
            Console.WriteLine("getting Toys Order");
            Console.WriteLine(base.ToString());
        }
    }
    class FurnitureOrder : Order
    {
        public FurnitureOrder(ProductType productType, Channel channel) : base(ProductType.Furniture, channel)
        {
            ProcessOrder();
        }
        public override void ProcessOrder()
        {
            Console.WriteLine("getting Furniture Order");
            Console.WriteLine(base.ToString());
        }
    }
}
