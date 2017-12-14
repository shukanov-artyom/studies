using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TestQuestionFlag
    {
        public TestQuestionFlag()
        {
            ProductAndTestQuestionFlagPermission = new HashSet<ProductAndTestQuestionFlagPermission>();
            TestQuestion = new HashSet<TestQuestion>();
            TestQuestionFlagLog = new HashSet<TestQuestionFlagLog>();
        }

        public int TestQuestionFlagId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public ICollection<ProductAndTestQuestionFlagPermission> ProductAndTestQuestionFlagPermission { get; set; }
        public ICollection<TestQuestion> TestQuestion { get; set; }
        public ICollection<TestQuestionFlagLog> TestQuestionFlagLog { get; set; }
    }
}
