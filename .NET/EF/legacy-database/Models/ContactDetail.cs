using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ContactDetail
    {
        public ContactDetail()
        {
            HospitalContactDetail = new HashSet<HospitalContactDetail>();
            OfficeContactDetail = new HashSet<OfficeContactDetail>();
            PracticeContactDetail = new HashSet<PracticeContactDetail>();
            PracticeSubscription = new HashSet<PracticeSubscription>();
        }

        public int ContactDetailId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<HospitalContactDetail> HospitalContactDetail { get; set; }
        public ICollection<OfficeContactDetail> OfficeContactDetail { get; set; }
        public ICollection<PracticeContactDetail> PracticeContactDetail { get; set; }
        public ICollection<PracticeSubscription> PracticeSubscription { get; set; }
    }
}
