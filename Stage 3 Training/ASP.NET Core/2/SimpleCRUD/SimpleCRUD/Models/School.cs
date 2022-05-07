using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class School
    {
        public int Id { get; set; }

        [Display(Name = "School Name")]
        [Required]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
