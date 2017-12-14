using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ColleagueGroup
    {
        public int UserId { get; set; }
        public string ColleagueGroup1 { get; set; }
        public int? Position { get; set; }

        public Users User { get; set; }
    }
}
