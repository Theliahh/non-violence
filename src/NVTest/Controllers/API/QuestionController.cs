using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NVTest.Models;

namespace NVTest.Controllers.API
{
    public class QuestionController : Controller
    {
        ITestRepository _repository;
        public QuestionController(ITestRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("api/questions")]
        public JsonResult Get()
        {
            var results = _repository.GetAllQuestions();

            return Json(results);
        }
    }
}
