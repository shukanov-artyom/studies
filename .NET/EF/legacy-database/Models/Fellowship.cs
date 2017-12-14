using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Fellowship
    {
        public Fellowship()
        {
            UserFellowship = new HashSet<UserFellowship>();
        }

        public int FellowshipId { get; set; }
        public string FellowshipName { get; set; }
        public string Acgmecode { get; set; }
        public string Specialty { get; set; }
        public string Subspecialty { get; set; }
        public string Programdirector { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Logourl { get; set; }
        public string LoadedBy { get; set; }
        public bool? Accredited { get; set; }

        public ICollection<UserFellowship> UserFellowship { get; set; }
    }
}
