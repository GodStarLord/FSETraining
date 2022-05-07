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
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly FinalCheckContext _context;

        public AdminController(FinalCheckContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()  //Get list of movies
        {
            var moviesList = _context.Movies.ToList();

            return Ok(moviesList);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return new OkObjectResult("Movie Added Succesfully");
        }

        [HttpPut]
        public IActionResult Put([FromBody] Movie movie)
        {
            var result = _context.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();

            if (result == null) return new NotFoundObjectResult("Invalid Id");

            result.Active = movie.Active;
            result.BoxOffice = movie.BoxOffice;
            result.DateOfLaunch = movie.DateOfLaunch;
            result.GenreId = movie.GenreId;
            result.HasTeaser = movie.HasTeaser;
            result.Title = movie.Title;

            _context.SaveChanges();
            return new OkObjectResult("Updated Succesfully");
        }

    }
}