using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserPublication
    {
        public int UserPublicationId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }

        public Post Post { get; set; }
        public Users User { get; set; }
    }
}
