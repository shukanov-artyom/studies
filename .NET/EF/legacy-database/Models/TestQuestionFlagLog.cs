using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TestQuestionFlagLog
    {
        public int TestQuestionFlagLogId { get; set; }
        public int TestQuestionId { get; set; }
        public int TestQuestionFlagId { get; set; }
        public int UserId { get; set; }
        public DateTime ActionDate { get; set; }
        public string Action { get; set; }

        public TestQuestionFlag TestQuestionFlag { get; set; }
        public Users User { get; set; }
    }
}
