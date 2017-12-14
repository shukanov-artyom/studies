using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PracticeOffice
    {
        public int PracticeOfficeId { get; set; }
        public int PracticeId { get; set; }
        public int OfficeId { get; set; }

        public Office Office { get; set; }
        public Practice Practice { get; set; }
    }
}
