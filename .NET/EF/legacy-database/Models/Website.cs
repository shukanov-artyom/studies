using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Website
    {
        public Website()
        {
            Product = new HashSet<Product>();
            Specialty = new HashSet<Specialty>();
            Users = new HashSet<Users>();
            UsersAndWebsite = new HashSet<UsersAndWebsite>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Hostname { get; set; }
        public bool? Active { get; set; }
        public int Order { get; set; }
        public string GoogleSearchEngineId { get; set; }
        public string DfpPropertyCode { get; set; }

        public ICollection<Product> Product { get; set; }
        public ICollection<Specialty> Specialty { get; set; }
        public ICollection<Users> Users { get; set; }
        public ICollection<UsersAndWebsite> UsersAndWebsite { get; set; }
    }
}
