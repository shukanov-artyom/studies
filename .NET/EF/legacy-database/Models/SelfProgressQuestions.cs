using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class SelfProgressQuestions
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public DateTime Timestamp { get; set; }
        public int Percentage { get; set; }

        public TestQuestion Question { get; set; }
        public Users User { get; set; }
    }
}
