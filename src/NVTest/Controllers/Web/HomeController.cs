using System;
using Microsoft.AspNet.Mvc;
using NVTest.Models;
using System.Linq;

namespace NVTest.Controllers.Web
{
    public class HomeController : Controller
    {
        TestContext _context;
        public HomeController(TestContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var questions = _context.Questions.OrderBy(t => t.QuestionText).ToList();
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult VK()
        {
            return View();
        }
    }
}
