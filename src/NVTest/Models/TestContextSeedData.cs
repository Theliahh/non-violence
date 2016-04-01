using System;
using System.Linq;

namespace NVTest.Models
{
	public class TestContextSeedData
    {
        private TestContext _context;

		public TestContextSeedData(TestContext context)
        {
            _context = context;
        }
		public void EnsureSeedData()
        {
			if(_context.Questions.Any())
            {
				//Add Question data
            }
        }
    }
}