using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Media
    {
        public Media()
        {
            PracticeMedia = new HashSet<PracticeMedia>();
            PracticeSubspecialty = new HashSet<PracticeSubspecialty>();
            UserMedia = new HashSet<UserMedia>();
        }

        public int MediaId { get; set; }
        public int MediaTypeId { get; set; }
        public string OriginalFilename { get; set; }
        public string ExternalUrl { get; set; }
        public int Orientation { get; set; }
        public int? Xdimension { get; set; }
        public int? Ydimension { get; set; }
        public DateTime CreateDate { get; set; }

        public MediaType MediaType { get; set; }
        public ICollection<PracticeMedia> PracticeMedia { get; set; }
        public ICollection<PracticeSubspecialty> PracticeSubspecialty { get; set; }
        public ICollection<UserMedia> UserMedia { get; set; }
    }
}
