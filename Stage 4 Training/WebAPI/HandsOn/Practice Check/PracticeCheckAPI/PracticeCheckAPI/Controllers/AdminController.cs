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
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private MenuOperation _context = new MenuOperation();

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.GetItems();
            
            return new OkObjectResult(result);
        }

        [HttpPost]
        public IActionResult Put([FromBody] MenuItem menuItem)
        {
            _context.AddItem(menuItem);
            
            return new OkObjectResult("Item Added Succesfully !!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] bool active)
        {
            var menu = _context.GetItem(id);
           
            if (menu == null) return new NotFoundObjectResult("Invalid Id");

            menu.Active = active;
            _context.UpdateItem(menu);
            
            return new OkObjectResult("Updated Succesfully !!");
        }

    }
}