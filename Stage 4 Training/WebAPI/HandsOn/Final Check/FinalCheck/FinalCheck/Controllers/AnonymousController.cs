using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCheck.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalCheck.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AnonymousController : ControllerBase
    {
        private readonly FinalCheckContext _context;

        public AnonymousController(FinalCheckContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            //return new OkObjectResult(_context.GetMovies());

            var moviesList = _context.Movies.ToList();

            return Ok(moviesList);
        }

    }
}