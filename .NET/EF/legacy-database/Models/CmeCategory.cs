using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CmeCategory
    {
        public CmeCategory()
        {
            Cme = new HashSet<Cme>();
        }

        public int CmeCategoryId { get; set; }
        public string Description { get; set; }

        public ICollection<Cme> Cme { get; set; }
    }
}
