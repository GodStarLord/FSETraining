using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeCheckAPI.Models;

namespace PracticeCheckAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private MenuOperation _context = new MenuOperation();

        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromBody] string password)
        {
            var user = _context.GetUser(id);

            if (user == null) return new BadRequestResult();
            else
            {
                bool flag = user.Password == password;
                if (flag) return new OkObjectResult("Successfully logged In");
                return new NotFoundObjectResult("False Submission");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            _context.AddUser(user);

            return new OkObjectResult("User added to database");
        }

    }
}