using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTestQuestion
    {
        public string TestCode { get; set; }
        public int QuestionId { get; set; }
        public int? OrderInTest { get; set; }

        public TestQuestion Question { get; set; }
    }
}
