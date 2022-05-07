using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ConsumeWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ConsumeWebAPI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string _baseURI;   //Uniform Resource Identifier

        public MovieController(IConfiguration configuration)    //Inject Configuration
        {
            _configuration = configuration;
            _baseURI = _configuration.GetValue<string>("ShowWebAPIBaseUrl");
        }

        // GET: Movie
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost:53781/api/Movie";

            var response = await client.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var resultRaw = response.Content.ReadAsAsync<List<Movie>>();
                var movies = resultRaw.Result;
                return View(movies);
            }

            return View("Error");
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Movie movie)
        {
            HttpClient client = new HttpClient();
            string uri = _baseURI;
            try
            {
                // TODO: Add insert logic here
                StringContent content = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(uri, content);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var resultRaw = JsonConvert.SerializeObject(movie);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception exception)
            {
                ModelState.Clear();
                ModelState.AddModelError("Error", "Error in creating movie");
                return View("Error");
            }

            return View();
        }

        // GET: Movie/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            HttpClient client = new HttpClient();
            string uri = _baseURI;

            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(id), Encoding.UTF8, "application/json");
                var response = await client.GetAsync(uri + $"/{id.ToString()}");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var resultRaw = response.Content.ReadAsAsync<Movie>();
                    var movie = resultRaw.Result;

                    return View(movie);
                }
            }
            catch (Exception e)
            {
                return View("Error");
            }

            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Movie movie)
        {
            HttpClient client = new HttpClient();
            string uri = _baseURI;

            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                var response = await client.PutAsync(uri + $"/{movie.Id.ToString()}", content);

                if (response.StatusCode == HttpStatusCode.OK)
                    return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }

            return View();
        }

        // GET: Movie/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            HttpClient client = new HttpClient();
            string uri = _baseURI;

            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(id), Encoding.UTF8, "application/json");
                var response = await client.GetAsync(uri + $"/{id.ToString()}");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var resultRaw = response.Content.ReadAsAsync<Movie>();
                    var movie = resultRaw.Result;

                    return View(movie);
                }
            }
            catch (Exception e)
            {
                return View("Error");
            }

            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            HttpClient client = new HttpClient();
            string uri = _baseURI;
            try
            {
                var response = await client.DeleteAsync(uri + $"/{id.ToString()}");
                
                if(response.StatusCode == HttpStatusCode.OK)
                    return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return View("Error");
            }

            return View();
        }
    }
}