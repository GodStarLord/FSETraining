using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCheck.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly FinalCheckContext _context;

        public UserController(FinalCheckContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromBody] string password)
        {
            var user = _context.Users.SingleOrDefault(x => x.Id == id);
            
            if (user == null) return BadRequest("No user found");

            if (user.Password == password) return Ok("Logged in successfully!!");

            return BadRequest("Incorrect details!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user.Password.Equals(user.ConfirmPassword))
            {
                _context.Users.Add(user);
                return Ok("Sign-Up Successful !");
            }

            return BadRequest("Passwords do not match, try again");
        }
    }
}