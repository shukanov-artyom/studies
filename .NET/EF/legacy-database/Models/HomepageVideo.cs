using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class HomepageVideo
    {
        public int HomepageVideoId { get; set; }
        public int PlaceholderId { get; set; }
        public int VideoId { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Users UpdatedByNavigation { get; set; }
        public Video Video { get; set; }
    }
}
