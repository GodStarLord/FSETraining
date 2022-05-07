using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using PurchaseMicroservice.DTO;
using PurchaseMicroservice.Models;

namespace PurchaseMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        public static List<Cart> Carts = new List<Cart>();
        public static List<Order> Orders = new List<Order>();
        private static int orderId = 0;

        [HttpPost]
        public ActionResult<Cart> Post([FromBody] Cart cart)    //add to cart
        {
            Carts.Add(cart);

            return Ok($"Cart added  {cart}");
        }

        [HttpDelete("deletec/{pid}")]
        public IActionResult Delete(int pid)    //remove from cart
        {
            var result =  Carts.Find(x => x.ProductId == pid);

            if (result == null) return BadRequest("No product found");

            Carts.Remove(Carts.Find(x => x.ProductId == pid));

            return Ok("Item removerd from the cart");
        }

        [HttpGet("confirmorder/{uid}")]
        public async Task<ActionResult<double>> ConfirmOrder(int uid) //confirm order for the user
        {
            List<Cart> tempCart = Carts.FindAll(x=>x.UserId == uid);
            List<int> pId = new List<int>();
            foreach (var cart in tempCart)
            {
                pId.Add(cart.ProductId);
            }

            double totalPrice = 0;

            foreach (var id in pId)
            {
                string baseURI = "http://localhost:54655/api/product/";

                HttpClient client = new HttpClient();

                try
                {
                    var response = await client.GetAsync(baseURI);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var products = response.Content.ReadAsAsync<List<ProductDTO>>().Result;

                        foreach (var product in products)
                        {
                            totalPrice += product.PricePerUnit;
                        }
                    }
                }

                catch (Exception e)
                {
                    return BadRequest("Error " + e.Message);
                }
            }

            Orders.Add(new Order() { OrderId = ++orderId, TotalPrice = totalPrice});
            return Ok(totalPrice);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)    //remove order
        {
            var result = Orders.Find(x => x.OrderId == id);

            if (result == null) return BadRequest("No order found");

            Orders.Remove(Orders.SingleOrDefault(x => x.OrderId == id));

            return Ok("Order Cancelled");
        }
    }
}
