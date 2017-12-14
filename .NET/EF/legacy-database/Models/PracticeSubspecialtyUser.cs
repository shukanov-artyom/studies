using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PracticeSubspecialtyUser
    {
        public int PracticeSubspecialtyUserId { get; set; }
        public int PracticeSubspecialtyId { get; set; }
        public int UserId { get; set; }
        public int SortOrder { get; set; }
        public string Description { get; set; }
        public DateTime Started { get; set; }

        public PracticeSubspecialty PracticeSubspecialty { get; set; }
        public Users User { get; set; }
    }
}
