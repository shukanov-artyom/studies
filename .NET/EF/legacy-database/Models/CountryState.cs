using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CountryState
    {
        public CountryState()
        {
            Group = new HashSet<Group>();
        }

        public int CountryStateId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int NumericCode { get; set; }

        public Country NumericCodeNavigation { get; set; }
        public ICollection<Group> Group { get; set; }
    }
}
