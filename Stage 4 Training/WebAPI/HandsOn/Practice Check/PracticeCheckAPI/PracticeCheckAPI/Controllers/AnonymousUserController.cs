using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeCheckAPI.Models;

namespace PracticeCheckAPI.Controllers
{
    //[AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AnonymousUserController : ControllerBase
    {
        private readonly MenuOperation _context;
        public AnonymousUserController()
        {
            _context = new MenuOperation();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.GetItems();
            return new OkObjectResult(result);
        }

    }
}