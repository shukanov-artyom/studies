using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserFellowship
    {
        public int UserFellowshipId { get; set; }
        public int UserId { get; set; }
        public int FellowshipId { get; set; }

        public Fellowship Fellowship { get; set; }
        public Users User { get; set; }
    }
}
