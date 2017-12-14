using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PracticePhone
    {
        public int PracticePhoneId { get; set; }
        public int PracticeId { get; set; }
        public int PhoneId { get; set; }

        public Phone Phone { get; set; }
        public Practice Practice { get; set; }
    }
}
