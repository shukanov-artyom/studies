using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTestmonial
    {
        public int UserTestmonialId { get; set; }
        public int UserId { get; set; }
        public int TestmonialId { get; set; }

        public Testmonial Testmonial { get; set; }
        public Users User { get; set; }
    }
}
