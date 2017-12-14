using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PracticeMedia
    {
        public int PracticeMediaId { get; set; }
        public int PracticeId { get; set; }
        public int MediaId { get; set; }
        public string Tag { get; set; }

        public Media Media { get; set; }
        public Practice Practice { get; set; }
    }
}
