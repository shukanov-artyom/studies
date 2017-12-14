using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserMedia
    {
        public int UserMediaId { get; set; }
        public int UserId { get; set; }
        public int MediaId { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

        public Media Media { get; set; }
        public Users User { get; set; }
    }
}
