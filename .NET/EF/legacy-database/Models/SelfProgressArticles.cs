using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class SelfProgressArticles
    {
        public int UserId { get; set; }
        public int ArticleId { get; set; }
        public DateTime Timestamp { get; set; }
        public int Percentage { get; set; }

        public Post Article { get; set; }
        public Users User { get; set; }
    }
}
