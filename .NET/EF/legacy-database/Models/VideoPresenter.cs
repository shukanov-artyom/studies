using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class VideoPresenter
    {
        public int VideoPresenterId { get; set; }
        public int VideoId { get; set; }
        public int UserId { get; set; }
        public string Questions { get; set; }
        public string TimeStamp { get; set; }

        public Users User { get; set; }
        public Video Video { get; set; }
    }
}
