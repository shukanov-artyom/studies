using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Residency
    {
        public Residency()
        {
            UserResidency = new HashSet<UserResidency>();
        }

        public int ResidencyId { get; set; }
        public string ResidencyName { get; set; }
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

        public ICollection<UserResidency> UserResidency { get; set; }
    }
}
