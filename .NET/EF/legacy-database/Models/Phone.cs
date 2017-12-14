using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Phone
    {
        public Phone()
        {
            HospitalPhone = new HashSet<HospitalPhone>();
            OfficePhone = new HashSet<OfficePhone>();
            PracticePhone = new HashSet<PracticePhone>();
            PracticeSubscription = new HashSet<PracticeSubscription>();
        }

        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneType { get; set; }
        public DateTime CreateDate { get; set; }
        public string PhoneMessage { get; set; }

        public ICollection<HospitalPhone> HospitalPhone { get; set; }
        public ICollection<OfficePhone> OfficePhone { get; set; }
        public ICollection<PracticePhone> PracticePhone { get; set; }
        public ICollection<PracticeSubscription> PracticeSubscription { get; set; }
    }
}
