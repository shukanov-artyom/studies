using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CommentReview
    {
        public int CommentId { get; set; }
        public int ReviewerId { get; set; }
        public DateTime? ReviewDate { get; set; }

        public Comment Comment { get; set; }
        public Users Reviewer { get; set; }
    }
}
