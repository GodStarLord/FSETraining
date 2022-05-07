using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattrenFinalCheckProject
{
    abstract class OrdersFactory
    {
        public abstract void BuildElectronic(Channel channel);
        public abstract void BuildToys(Channel channel);
        public abstract void BuildFurniture(Channel channel);

    }
}
