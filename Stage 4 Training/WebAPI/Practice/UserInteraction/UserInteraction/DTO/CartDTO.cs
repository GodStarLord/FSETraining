using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInteraction.DTO
{
    public class CartDTO
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
