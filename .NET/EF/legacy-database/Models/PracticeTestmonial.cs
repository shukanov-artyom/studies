using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PracticeTestmonial
    {
        public int PracticeTestmonialId { get; set; }
        public int PracticeId { get; set; }
        public int TestmonialId { get; set; }

        public Practice Practice { get; set; }
        public Testmonial Testmonial { get; set; }
    }
}
