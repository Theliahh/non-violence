using System;

namespace NVTest.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string firstChoice { get; set; }
        public string secondChoice { get; set; }
        public bool? isRelevant { get; set; }
        public short? nvChoice { get; set; }
    }
}
