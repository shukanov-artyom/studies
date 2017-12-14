using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserVideoTagged
    {
        public int VideoId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public Users User { get; set; }
        public Video Video { get; set; }
    }
}
