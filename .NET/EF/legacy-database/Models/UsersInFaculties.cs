using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UsersInFaculties
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }

        public Users User { get; set; }
    }
}
