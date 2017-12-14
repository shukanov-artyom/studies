using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class BiannualReportPeriod
    {
        public int BiannualReportPeriodId { get; set; }
        public int StartDay { get; set; }
        public int StartMonth { get; set; }
        public int EndDay { get; set; }
        public int EndMonth { get; set; }
        public string PeriodTitle { get; set; }
    }
}
