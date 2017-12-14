using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Country
    {
        public Country()
        {
            CountryState = new HashSet<CountryState>();
            Group = new HashSet<Group>();
        }

        public int NumericCode { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string EnglishSortName { get; set; }

        public ICollection<CountryState> CountryState { get; set; }
        public ICollection<Group> Group { get; set; }
    }
}
