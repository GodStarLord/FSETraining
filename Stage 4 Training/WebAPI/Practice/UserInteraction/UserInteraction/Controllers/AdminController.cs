using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UserInteraction.DTO;

namespace UserInteraction.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private string _baseURI = "http://localhost:54655/api/product"; //Product Micro-service

        [HttpPost("addproduct")]
        public async Task<ActionResult> Post(ProductDTO product)
        {
            HttpClient client = new HttpClient();

            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8,
                    "application/json");

                var response = await client.PostAsync(_baseURI, content);

                if (response.StatusCode == HttpStatusCode.OK)
                    return Ok("Product Added Successfully");
            }

            catch (Exception e)
            {
                return BadRequest("Unable to add product" + e.Message);
            }

            return BadRequest("Unable to add product");
        }

        [HttpPut("updateproduct")]
        public async Task<ActionResult> UpdateProduct(ProductDTO product)
        {
            HttpClient client = new HttpClient();
            _baseURI += "/updateproduct";

            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8,
                    "application/json");

                var response = await client.PutAsync(_baseURI, content);

                if (response.StatusCode == HttpStatusCode.OK)
                    return Ok("Product details update Successfull !!");
            }

            catch (Exception e)
            {
                return BadRequest("Unable to update product" + e.Message);
            }

            return BadRequest("Unable to update product");
        }
    }
}