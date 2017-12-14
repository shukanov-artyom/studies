using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Testmonial
    {
        public Testmonial()
        {
            PracticeTestmonial = new HashSet<PracticeTestmonial>();
            UserTestmonial = new HashSet<UserTestmonial>();
        }

        public int TestmonialId { get; set; }
        public int UserId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorPhotoUrl { get; set; }
        public DateTime? TestmonialDate { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public DateTime? CreateDate { get; set; }

        public Users User { get; set; }
        public ICollection<PracticeTestmonial> PracticeTestmonial { get; set; }
        public ICollection<UserTestmonial> UserTestmonial { get; set; }
    }
}
