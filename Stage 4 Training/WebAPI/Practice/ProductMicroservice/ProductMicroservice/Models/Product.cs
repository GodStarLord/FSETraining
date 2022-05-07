using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroservice.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductaName { get; set; }
        public bool IsAvailable { get; set; }
        public double PricePerUnit { get; set; }
        public int NoOfProducts { get; set; }
    }
}
