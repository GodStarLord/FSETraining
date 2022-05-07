﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCheck.Models
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }

    }
}
