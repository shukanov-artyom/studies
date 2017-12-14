using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class EfootprintContentType
    {
        public EfootprintContentType()
        {
            EfootprintContent = new HashSet<EfootprintContent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EfootprintContent> EfootprintContent { get; set; }
    }
}
