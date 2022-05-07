using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackMicroservice.Models
{
    public class Feedback
    {
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}
