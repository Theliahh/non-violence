using System.Collections.Generic;

namespace NVTest.Models
{
    public interface ITestRepository
    {
        IEnumerable<Question> GetAllQuestions();
        Question GetQuestionByNumber(int QNumber);
    }
}