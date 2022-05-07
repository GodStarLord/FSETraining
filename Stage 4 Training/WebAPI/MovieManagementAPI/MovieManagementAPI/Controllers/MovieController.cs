using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieManagementAPI.Models;

namespace MovieManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ShowContext _context;

        public MovieController(ShowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Get()   //Select all the record
        {
            var result = await _context.Movies.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> Get(int id)   //search based on id
        {
            var result = await _context.Movies.SingleOrDefaultAsync(x => x.Id == id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> Post(Movie movie)    //Add A Record
        {
            try
            {
                _context.Add(movie);    //This also works, but little slower as it needs to identify the type by matching
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest("Exception: " + e.Message);
            }

            return Ok(movie);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Movie>> Put([FromBody]Movie movie, int id)
        {
            try
            {
                var result = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
                result.Name = movie.Name;
                result.Remarks = movie.Remarks;
                result.Duration = movie.Duration;

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest("Exception: " + e.Message);
            }

            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> Delete(int id)
        {
            try
            {
                var result = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
                _context.Movies.Remove(result);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest("Exception: " + e.Message);
            }

            return Ok();
        }
    }
}