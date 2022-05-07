using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Models;

namespace ProductMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> products = new List<Product>()
        {
            new Product() {Id = 101, ProductaName = "Powder", IsAvailable = true, NoOfProducts = 10, PricePerUnit = 25},
            new Product() {Id = 102, ProductaName = "Soap", IsAvailable = true, NoOfProducts = 5, PricePerUnit = 15},
            new Product() {Id = 103, ProductaName = "Pens", IsAvailable = false, NoOfProducts = 16, PricePerUnit = 4},
            new Product() {Id = 104, ProductaName = "Lock", IsAvailable = true, NoOfProducts = 10, PricePerUnit = 60},
        };

        //[Authorize(Roles = "Customer,Admin")]
        [HttpGet]
        public IActionResult Get()
        {
            if (products != null) return Ok(products);
            return BadRequest();
        }

        //[Authorize(Roles = "Customer,Admin")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.Find(x => x.Id == id);

            if (product == null) return BadRequest();

            return Ok(product);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            try
            {
                products.Add(product);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        //[Authorize(Roles = "Admin")]
        [HttpPut("updateproduct")]
        public IActionResult UpdateProduct([FromBody]Product product)
        {
            var result = products
                .SingleOrDefault(x => x.Id == product.Id);

            if (result == null)
            {
                return BadRequest("No product found");
            }

            int index = products.IndexOf(result);

            products[index].ProductaName = product.ProductaName;
            products[index].IsAvailable = product.IsAvailable;
            products[index].NoOfProducts = product.NoOfProducts;
            products[index].PricePerUnit = product.PricePerUnit;

            return Ok();
        }
    }
}