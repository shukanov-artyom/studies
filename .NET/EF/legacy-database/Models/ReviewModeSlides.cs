using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ReviewModeSlides
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string FileUrl { get; set; }
        public DateTime LoadDate { get; set; }

        public TestQuestion Question { get; set; }
        public Users User { get; set; }
    }
}
