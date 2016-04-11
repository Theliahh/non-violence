using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVTest.Models
{
    public class ResultsRepository : IResultsRepository
    {
        private ResultsContext _context;
        public ResultsRepository(ResultsContext context)
        {
            _context = context;
        }
        public float ScoreForAgeGroup(int low, int high)
        {
            List<Result> scores = _context.Results.Where(c => c.Age >= low && c.Age <= high).ToList();
            float avgScore = 0;
            foreach (var item in scores)
            {
                avgScore += item.Score;
            }
            avgScore = avgScore / scores.Count;
            return avgScore;
        }


        public float ScoreForGender(string gender)
        {
            List<Result> scores = _context.Results.Where(c => c.Gender == gender).ToList();
            float avgScore = 0;
            foreach (var item in scores)
            {
                avgScore += item.Score;
            }
            avgScore = avgScore / scores.Count;
            return avgScore;
        }
    }
}
