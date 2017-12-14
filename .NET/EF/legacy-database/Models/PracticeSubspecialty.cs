using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PracticeSubspecialty
    {
        public PracticeSubspecialty()
        {
            PracticeSubspecialtyUser = new HashSet<PracticeSubspecialtyUser>();
        }

        public int PracticeSubspecialtyId { get; set; }
        public int PracticeId { get; set; }
        public int SubspecialtyId { get; set; }
        public int? MediaId { get; set; }

        public Media Media { get; set; }
        public Practice Practice { get; set; }
        public ICollection<PracticeSubspecialtyUser> PracticeSubspecialtyUser { get; set; }
    }
}
