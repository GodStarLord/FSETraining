using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracCheck.BO;
using PracCheck.Models;

namespace PracCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private MenuOperation _operation;

        public AdminController(MenuOperation operation)
        {
            _operation = operation;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var menuItemList = _operation.GetMenuItems();

            return Ok(menuItemList);
        }


        [HttpPost]
        public IActionResult Post([FromBody] MenuItem menuItem)
        {
            _operation.AddItem(menuItem);

            return Ok("Item Added Successfully!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MenuItem menuItem)
        {
            var menuItems = _operation.GetMenuItems();
            var result = menuItems.Find(x => x.Id == id);

            if (result == null) return BadRequest("Invalid Id");
            else
            {
                result.Name = menuItem.Name;
                result.Price = menuItem.Price;
                result.DateOfLaunch = menuItem.DateOfLaunch;
                result.FreeDelivery = menuItem.FreeDelivery;
                result.CategoryName = menuItem.CategoryName;
                result.Active = menuItem.Active;

                _operation.Update(result);
            }

            return Ok(result);
        }
    }
}