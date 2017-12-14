using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class FreePdfStatistics
    {
        public int FreePdfStatisticId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Pmid { get; set; }
        public string FreePdfUrl { get; set; }
        public DateTime Date { get; set; }

        public Post Post { get; set; }
        public Users User { get; set; }
    }
}
