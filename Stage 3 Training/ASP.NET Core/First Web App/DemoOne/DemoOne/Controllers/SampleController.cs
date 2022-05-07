using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoOne.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View("Sample");
        }
    }
}