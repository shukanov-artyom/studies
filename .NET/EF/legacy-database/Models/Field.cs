using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Field
    {
        public Field()
        {
            Chapter = new HashSet<Chapter>();
        }

        public int FieldId { get; set; }
        public int SubspecialtyId { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }
        public int Sortorder { get; set; }

        public Subspecialty Subspecialty { get; set; }
        public ICollection<Chapter> Chapter { get; set; }
    }
}
