using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVTest.Models
{
    public class TestRepository : ITestRepository
    {
        private TestContext _context;
        public TestRepository(TestContext context)
        {
            _context = context;
        }
        public IEnumerable<Question> GetAllQuestions()
        {
            return _context.Questions.OrderBy(n => n.QuestionNumber).ToList();
        }

        public Question GetQuestionByNumber(int QNumber)
        {
            return _context.Questions.Where(n => n.QuestionNumber == QNumber).Single();
        }
    }
}
