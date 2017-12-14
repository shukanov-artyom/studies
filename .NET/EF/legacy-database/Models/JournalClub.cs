using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class JournalClub
    {
        public JournalClub()
        {
            Post = new HashSet<Post>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string JournalCoverUrl { get; set; }
        public string MedlineTa { get; set; }
        public bool? IsAbstractShown { get; set; }
        public bool? IsBulletsSummaryShown { get; set; }
        public string ShortTitle { get; set; }
        public int? PublisherId { get; set; }

        public Publisher Publisher { get; set; }
        public ICollection<Post> Post { get; set; }
    }
}
