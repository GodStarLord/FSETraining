using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackMicroservice.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeedbackMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {

        public static List<Feedback> Feedbacks = new List<Feedback>()
        {
            new Feedback() { UserId = 1, Description = "It's Awesome!!"}
        };

        // GET: api/<FeedbackController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Feedbacks);
        }

        // GET api/<FeedbackController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = Feedbacks.Find(x => x.UserId == id);
            
            if (result == null) return BadRequest("No feedback available for the user");

            return Ok(result);
        }

        // POST api/<FeedbackController>
        [HttpPost]
        public IActionResult Post([FromBody] Feedback feedback)
        {
            Feedbacks.Add(feedback);

            return Ok("Feedback Added!!");
        }
    }
}
