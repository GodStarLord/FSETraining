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
    [Authorize(Roles = "Customer")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private MenuOperation _context = new MenuOperation();

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.GetItems().Where(x => x.Active == true && x.DateOfLaunch <= DateTime.Now);
            
            return new OkObjectResult(result);
        }

        [HttpGet("{userId}")]
        public IActionResult Get(int userId)
        {
            var items = _context.GetCartItems(userId);
            double total = 0;

            foreach (var item in items)
            {
                total += _context.GetItem(item.MenuItemId).Price;
            }

            return new OkObjectResult(items + "\n" + total);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cart cart)
        {
            _context.AddCartItem(cart);

            return new OkObjectResult("Item Added to Cart");
        }

        [HttpDelete("{menuid}")]
        public IActionResult Delete(int menuid)
        {
            _context.DeleteCartItem(menuid);

            return new OkObjectResult("Removed Item from cart");
        }

    }
}