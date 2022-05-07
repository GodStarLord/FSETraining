using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCheck.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string BoxOffice { get; set; }
        public bool Active { get; set; }
        public DateTime DateOfLaunch { get; set; }
        public bool HasTeaser { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }

    }
}
