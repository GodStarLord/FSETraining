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
    [Authorize(Roles = "Customer")]
    [Route("api/[controller]")]
    [ApiController]
    public class NewCustomerController : ControllerBase
    {
        private readonly MenuOperation _operation;

        public NewCustomerController(MenuOperation operation)
        {
            _operation = operation;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _operation.GetMenuItems()
                .Find(x => x.Active == true && x.DateOfLaunch <= DateTime.Now);
            return Ok(result);
        }

        [HttpGet("{userId}")]
        public IActionResult Get(int userId)
        {
            var items = _operation.GetCartItems(userId);
            
            double total = 0;

            foreach (var item in items)
            {
                total += _operation.GetMenuItem(item.MenuItemId).Price;
            }

            return new OkObjectResult(items + "\n" + total);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cart cart)
        {
            _operation.AddCartItem(cart);

            return Ok("Item Added to Cart");
        }

        [HttpDelete("{menuid}")]
        public IActionResult Delete(int menuid)
        {
            _operation.DeleteCartItem(menuid);

            return Ok("Removed Item from cart");
        }



    }
}