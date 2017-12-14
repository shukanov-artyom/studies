using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class MedicalSchool
    {
        public MedicalSchool()
        {
            UserMedicalSchool = new HashSet<UserMedicalSchool>();
        }

        public int MedicalSchoolId { get; set; }
        public string MedicalSchoolName { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Opeid { get; set; }
        public string Logourl { get; set; }
        public string LoadedBy { get; set; }

        public ICollection<UserMedicalSchool> UserMedicalSchool { get; set; }
    }
}
