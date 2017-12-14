using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class BiannualReportUser
    {
        public int BiannualReportUserId { get; set; }
        public int BiannualReportId { get; set; }
        public int UserId { get; set; }
        public bool IsCompleted { get; set; }
        public decimal? GradeLevel { get; set; }
        public int? GradeValue { get; set; }

        public BiannualReport BiannualReport { get; set; }
        public Users User { get; set; }
    }
}
