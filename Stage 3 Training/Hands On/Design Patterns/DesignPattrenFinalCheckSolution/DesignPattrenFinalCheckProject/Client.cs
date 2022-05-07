using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattrenFinalCheckProject
{
    class Client
    {
        private readonly OrdersFactory _orderFactory;
        public Client(OrdersFactory ordersFactory)
        {
            _orderFactory = ordersFactory;
        }
        public void BuildElectronic(Channel channel)
        {
            _orderFactory.BuildElectronic(channel);
        }
        public void BuildToys(Channel channel)
        {
            _orderFactory.BuildToys(channel);
        }
        public void BuildFurniture(Channel channel)
        {
            _orderFactory.BuildFurniture(channel);
        }

    }
}
