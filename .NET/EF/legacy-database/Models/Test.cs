using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Test
    {
        public Test()
        {
            TestQuestion = new HashSet<TestQuestion>();
        }

        public string TestName { get; set; }
        public string OriginalTest { get; set; }
        public string NewTest { get; set; }
        public int? Year { get; set; }
        public int? OriginalTestCategory { get; set; }
        public int TestId { get; set; }
        public int QuestionSourceCategoryId { get; set; }

        public QuestionSourceCategory QuestionSourceCategory { get; set; }
        public ICollection<TestQuestion> TestQuestion { get; set; }
    }
}
