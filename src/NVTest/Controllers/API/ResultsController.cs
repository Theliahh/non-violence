using Microsoft.AspNet.Mvc;
using NVTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVTest.Controllers.API
{
    public class ResultsController : Controller
    {
        IResultsRepository _repository;
        public ResultsController(IResultsRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("api/results/gender")]
        public float GetGenderAverage([FromBody]string gender)
        {
            return _repository.ScoreForGender(gender);
        }
        [HttpPost("api/results")]
        public JsonResult PostToDb([FromBody]Result newResult)
        {
            _repository.AddNewResult(newResult);
            return Json(newResult);
        }

    }
}
