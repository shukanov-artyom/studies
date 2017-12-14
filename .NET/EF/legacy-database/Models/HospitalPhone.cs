using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class HospitalPhone
    {
        public int HospitalPhoneId { get; set; }
        public int HospitalId { get; set; }
        public int PhoneId { get; set; }

        public Hospital Hospital { get; set; }
        public Phone Phone { get; set; }
    }
}
