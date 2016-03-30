using System;
using Microsoft.AspNet.Mvc;

namespace NVTest.Controllers.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }//test
}
