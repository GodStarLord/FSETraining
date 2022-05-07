using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace LogForNet.Controllers
{
    public class HomeController : Controller
    {
        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));

        public ActionResult Index()
        {
            log.Debug("This is Debug message");
            log.Warn("This is Warn message");
            log.Error("This is Error message");
            log.Fatal("This is Fatal message");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}