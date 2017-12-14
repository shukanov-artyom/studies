using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class HospitalContactDetail
    {
        public int HospitalContactDetailId { get; set; }
        public int HospitalId { get; set; }
        public int ContactDetailId { get; set; }

        public ContactDetail ContactDetail { get; set; }
        public Hospital Hospital { get; set; }
    }
}
