using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattrenFinalCheckProject
{
    abstract class Order
    {
        public Order(ProductType type,Channel channel)
        {
            this.ProductType = type;
            this.Channel = channel;
        }
        public abstract void ProcessOrder();
        public ProductType ProductType { get; set; }
        public Channel Channel { get; set; }
        public override string ToString()
        {
            return "ProductType-" + ProductType.ToString() + " through the channel- " + Channel.ToString();
        }
    }
}
