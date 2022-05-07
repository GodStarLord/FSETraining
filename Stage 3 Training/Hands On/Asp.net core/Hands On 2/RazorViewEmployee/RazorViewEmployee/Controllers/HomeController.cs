using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorViewEmployee.Models;

namespace RazorViewEmployee.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("GetEmployeeList");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetEmployeeList()
        {
            var empList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "John", Salary = 10000, IsPermanent = true},
                new Employee() { Id = 2, Name = "Smith", Salary = 5000, IsPermanent = false},
                new Employee() { Id = 3, Name = "Mark", Salary = 6000, IsPermanent = false},
                new Employee() { Id = 4, Name = "Mary", Salary = 5000, IsPermanent = false},
            };



            return View(empList);
        }
    }
}
