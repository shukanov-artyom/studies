using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class VideoQuestionTimeStamp
    {
        public int VideoQuestionTimeStampId { get; set; }
        public int VideoId { get; set; }
        public int QuestionId { get; set; }
        public string TimeStamp { get; set; }

        public TestQuestion Question { get; set; }
        public Video Video { get; set; }
    }
}
