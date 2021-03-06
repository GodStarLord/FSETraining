using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracCheck.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool Active { get; set; }

        [Required]
        public double Price { get; set; }

        [Display(Name = "Date Of Launch")]
        public DateTime DateOfLaunch { get; set; }

        [Display(Name = "Free Delivery")]
        public bool FreeDelivery { get; set; }

        [Display(Name = "Category")]
        public string CategoryName { get; set; }

    }
}
