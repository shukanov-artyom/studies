using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Office
    {
        public Office()
        {
            OfficeContactDetail = new HashSet<OfficeContactDetail>();
            OfficePhone = new HashSet<OfficePhone>();
            OfficeUser = new HashSet<OfficeUser>();
            PracticeOffice = new HashSet<PracticeOffice>();
        }

        public int OfficeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Shortcut { get; set; }
        public DateTime CreateDate { get; set; }
        public string Schedule { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public int OfficeType { get; set; }

        public ICollection<OfficeContactDetail> OfficeContactDetail { get; set; }
        public ICollection<OfficePhone> OfficePhone { get; set; }
        public ICollection<OfficeUser> OfficeUser { get; set; }
        public ICollection<PracticeOffice> PracticeOffice { get; set; }
    }
}
