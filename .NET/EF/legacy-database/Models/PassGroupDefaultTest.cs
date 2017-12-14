using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassGroupDefaultTest
    {
        public int Id { get; set; }
        public string TestCode { get; set; }
        public int SpecialtyId { get; set; }

        public UserTest TestCodeNavigation { get; set; }
    }
}
