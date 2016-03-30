using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVTest.wwwroot.Models
{
    class Question
    {
        public string QuestionText { get; set; }
        public string firstChoice { get; set; }
        public string secondChoice { get; set; }
        public bool isRelevant { get; set; }
        public short? nvChoice { get; set; }
    }
}
