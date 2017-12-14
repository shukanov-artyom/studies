using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class SelfProgressVideo
    {
        public int UserId { get; set; }
        public int VideoId { get; set; }
        public DateTime Timestamp { get; set; }
        public int Percentage { get; set; }

        public Users User { get; set; }
        public Video Video { get; set; }
    }
}
