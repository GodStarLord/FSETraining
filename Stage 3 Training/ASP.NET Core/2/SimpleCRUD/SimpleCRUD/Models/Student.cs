using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }
        public School School { get; set; }

        [Required]
        [Display(Name = "School Name")]
        public int SchoolId { get; set; }
    }
}
