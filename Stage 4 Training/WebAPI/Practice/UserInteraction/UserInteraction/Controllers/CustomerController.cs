using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using UserInteraction.DTO;

namespace UserInteraction.Controllers
{
    [Authorize(Roles = "Customer")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private string _baseURI = "http://localhost:17710/api/feedback"; //Feedback Miroservice

        [HttpGet("getfeedback")]
        public async Task<ActionResult> Get()
        {
            HttpClient client = new HttpClient();

            try
            {
                var response = await client.GetAsync(_baseURI);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var feedbacks = response.Content.ReadAsAsync<List<FeedbackDTO>>().Result;
                    return Ok(feedbacks);
                }
            }

            catch (Exception e)
            {
                return BadRequest("Unable to get feedback " + e.Message);
            }

            return BadRequest("Unable to get feedback");
        }

        [HttpPost("addfeedback")]
        public async Task<ActionResult> Post(FeedbackDTO feedback)
        {
            HttpClient client = new HttpClient();

            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(feedback), Encoding.UTF8,
                    "application/json");

                var response = await client.PostAsync(_baseURI, content);

                if (response.StatusCode == HttpStatusCode.OK)
                    return Ok("Feedback Added Successfully");
            }

            catch (Exception e)
            {
                return BadRequest("Unable to add feedback " + e.Message);
            }

            return BadRequest("Unable to add feedback ");
        }

        [HttpGet("getproducts")]
        public async Task<ActionResult> GetProducts()
        {
            HttpClient client = new HttpClient();

            try
            {
                _baseURI = "http://localhost:54655/api/product";    //product
                var response = await client.GetAsync(_baseURI);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var products = response.Content.ReadAsAsync<List<ProductDTO>>().Result;
                    return Ok(products);
                }
            }

            catch (Exception e)
            {
                return BadRequest("Unable to get product " + e.Message);
            }

            return BadRequest("Unable to get products");
        }

        [HttpPost("addcart")]
        public async Task<ActionResult> Post(CartDTO cart)
        {
            _baseURI = "http://localhost:33446/api/purchase";
            HttpClient client = new HttpClient();

            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(cart), Encoding.UTF8,
                    "application/json");

                var response = await client.PostAsync(_baseURI, content);

                if (response.StatusCode == HttpStatusCode.OK)
                    return Ok("Cart Added");
            }

            catch (Exception e)
            {
                return BadRequest("Unable to add cart " + e.Message);
            }

            return BadRequest("Unable to add cart ");
        }

        [HttpDelete("deletecitem")]
        public async Task<ActionResult> Delete(int pId)
        {
            _baseURI = "http://localhost:33446/api/purchase/deletec/" + pId;
            HttpClient client = new HttpClient();

            try
            {

                var response = await client.DeleteAsync(_baseURI);

                if (response.StatusCode == HttpStatusCode.OK)
                    return Ok("Delete Successfull");
            }

            catch (Exception e)
            {
                return BadRequest("Unable to delete " + e.Message);
            }

            return BadRequest("Unable to delete ");
        }

        [HttpGet("confirmorder")]
        public async Task<ActionResult> ConfirmOrder(int uid)
        {
            HttpClient client = new HttpClient();

            try
            {
                _baseURI = "http://localhost:33446/api/purchase/confirmorder/" + uid;    //product
                var response = await client.GetAsync(_baseURI);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //var products = response.Content.ReadAsStreamAsync();
                    var totalPrice = response.Content.ReadAsAsync<double>().Result;
                    
                    return Ok($"Order Confirmed, Total Price = {totalPrice}");
                }
            }

            catch (Exception e)
            {
                return BadRequest("Error " + e.Message);
            }

            return BadRequest("Error");
        }

        [HttpDelete("cancelorder")]
        public async Task<ActionResult> CancelOrder(int id)
        {
            _baseURI = "http://localhost:33446/api/purchase/" + id;
            HttpClient client = new HttpClient();

            try
            {

                var response = await client.DeleteAsync(_baseURI);

                if (response.StatusCode == HttpStatusCode.OK)
                    return Ok("Delete Successfull");
            }

            catch (Exception e)
            {
                return BadRequest("Unable to delete " + e.Message);
            }

            return BadRequest("Unable to delete ");
        }
    }
}
