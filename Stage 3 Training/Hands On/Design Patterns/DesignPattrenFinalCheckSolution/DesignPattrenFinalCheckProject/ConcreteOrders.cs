using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattrenFinalCheckProject
{
    class ConcreteOrders : OrdersFactory
    {
        Order order;
        public override void BuildElectronic(Channel channel)
        {
            order = new ElectronicOrder(ProductType.ElectronicProduct, channel); 
        }

        public override void BuildFurniture(Channel channel)
        {
            order = new FurnitureOrder(ProductType.Furniture, channel);
        }

        public override void BuildToys(Channel channel)
        {
            order = new ToysOrder(ProductType.Toys, channel);
        }
    }
}
