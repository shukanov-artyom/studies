using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class EfootprintContent
    {
        public int Id { get; set; }
        public int EfootprintId { get; set; }
        public int ContentTypeId { get; set; }
        public string Description { get; set; }

        public EfootprintContentType ContentType { get; set; }
        public Efootprint Efootprint { get; set; }
    }
}
