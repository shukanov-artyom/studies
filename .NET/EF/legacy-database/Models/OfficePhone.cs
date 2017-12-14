using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class OfficePhone
    {
        public int OfficePhoneId { get; set; }
        public int OfficeId { get; set; }
        public int PhoneId { get; set; }

        public Office Office { get; set; }
        public Phone Phone { get; set; }
    }
}
