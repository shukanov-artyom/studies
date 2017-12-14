using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PracticeContactDetail
    {
        public int PracticeContactDetailId { get; set; }
        public int PracticeId { get; set; }
        public int ContactDetailId { get; set; }

        public ContactDetail ContactDetail { get; set; }
        public Practice Practice { get; set; }
    }
}
