using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class EfootprintRefs
    {
        public int Id { get; set; }
        public int EfootprintId { get; set; }
        public int TypeId { get; set; }
        public string RefId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool IsAgainst { get; set; }
        public Guid ActionGuid { get; set; }

        public Users CreatedByNavigation { get; set; }
        public Efootprint Efootprint { get; set; }
    }
}
