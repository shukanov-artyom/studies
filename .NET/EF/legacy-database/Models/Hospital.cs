using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Hospital
    {
        public Hospital()
        {
            HospitalContactDetail = new HashSet<HospitalContactDetail>();
            HospitalPhone = new HashSet<HospitalPhone>();
            HospitalUser = new HashSet<HospitalUser>();
        }

        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Shortcut { get; set; }
        public DateTime CreateDate { get; set; }
        public string Photo { get; set; }

        public ICollection<HospitalContactDetail> HospitalContactDetail { get; set; }
        public ICollection<HospitalPhone> HospitalPhone { get; set; }
        public ICollection<HospitalUser> HospitalUser { get; set; }
    }
}
