using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTestQuestionTagged
    {
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public TestQuestion Question { get; set; }
        public Users User { get; set; }
    }
}
