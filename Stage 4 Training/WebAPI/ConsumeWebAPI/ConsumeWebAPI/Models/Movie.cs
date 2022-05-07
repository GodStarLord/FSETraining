using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeWebAPI.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Cannot be Empty")]
        public string Name { get; set; }

        public float Duration { get; set; }

        public string Remarks { get; set; }
    }
}
