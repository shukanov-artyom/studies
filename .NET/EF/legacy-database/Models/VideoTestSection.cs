using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class VideoTestSection
    {
        public int VideoTestSectionId { get; set; }
        public string TestCode { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string TimeStamp { get; set; }
        public string Title { get; set; }

        public TestQuestion Question { get; set; }
        public Users User { get; set; }
    }
}
