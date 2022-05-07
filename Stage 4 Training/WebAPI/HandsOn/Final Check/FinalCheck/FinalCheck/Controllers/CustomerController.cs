using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCheck.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalCheck.Controllers
{
    //[Authorize(Roles = "Customer")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly FinalCheckContext _context;

        public CustomerController(FinalCheckContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var movies = _context.Movies
                .Where(x => x.DateOfLaunch <= DateTime.Now && x.Active == true)
                .ToList();
            
            return new OkObjectResult(movies);
        }

        [HttpGet("{userId}")]
        public IActionResult Get(int userId)
        {
            var favoriteList = _context.Favorites
                .Include(x => x.Movie)
                .Where(x => x.UserId == userId)
                .ToList();

            if (favoriteList == null) return new NotFoundObjectResult("Favorite List for this user not found!!");

            return new OkObjectResult(favoriteList + "Total Movies" + favoriteList.Count);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Favorite favorite)
        {
            _context.Favorites.Add(favorite);
            _context.SaveChanges();

            return new OkObjectResult("Movie Added to Favorites");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var favorite = (Favorite)_context.Favorites
                .Include(x => x.Movie)
                .SingleOrDefault(x=>x.MovieId == id);

            if (favorite == null) return new NotFoundObjectResult("Movie not found");

            _context.Favorites.Remove(favorite);
            _context.SaveChanges();

            return new OkObjectResult("Removed Movie from Favorite");
        }

    }
}