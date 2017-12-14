using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserArticleTagged
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public Post Article { get; set; }
        public Users User { get; set; }
    }
}
