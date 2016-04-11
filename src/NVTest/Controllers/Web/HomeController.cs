using System;
using Microsoft.AspNet.Mvc;
using NVTest.Models;
using System.Linq;

namespace NVTest.Controllers.Web
{
    public class HomeController : Controller
    {
        private ITestRepository _repository;
        private IResultsRepository _resultsRepository;
        public HomeController(ITestRepository repository, IResultsRepository resultsRepository)
        {
            _repository = repository;
            _resultsRepository = resultsRepository;
        }
        public IActionResult Index()
        {
            var questions = _repository.GetAllQuestions();
            return View(questions);
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
