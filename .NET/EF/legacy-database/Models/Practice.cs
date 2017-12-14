using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Practice
    {
        public Practice()
        {
            PracticeContactDetail = new HashSet<PracticeContactDetail>();
            PracticeMedia = new HashSet<PracticeMedia>();
            PracticeOffice = new HashSet<PracticeOffice>();
            PracticePhone = new HashSet<PracticePhone>();
            PracticeSubscription = new HashSet<PracticeSubscription>();
            PracticeSubspecialty = new HashSet<PracticeSubspecialty>();
            PracticeTestmonial = new HashSet<PracticeTestmonial>();
        }

        public int PracticeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string Logo { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Slogan1 { get; set; }
        public string Slogan2 { get; set; }
        public string Slogan3 { get; set; }

        public ICollection<PracticeContactDetail> PracticeContactDetail { get; set; }
        public ICollection<PracticeMedia> PracticeMedia { get; set; }
        public ICollection<PracticeOffice> PracticeOffice { get; set; }
        public ICollection<PracticePhone> PracticePhone { get; set; }
        public ICollection<PracticeSubscription> PracticeSubscription { get; set; }
        public ICollection<PracticeSubspecialty> PracticeSubspecialty { get; set; }
        public ICollection<PracticeTestmonial> PracticeTestmonial { get; set; }
    }
}
