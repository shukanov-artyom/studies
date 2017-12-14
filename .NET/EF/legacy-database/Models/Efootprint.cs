using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Efootprint
    {
        public Efootprint()
        {
            EfootprintContent = new HashSet<EfootprintContent>();
            EfootprintRefs = new HashSet<EfootprintRefs>();
        }

        public int Id { get; set; }
        public int TypeId { get; set; }
        public int RefId { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? PollId { get; set; }
        public string PollOption { get; set; }
        public int? Author2Id { get; set; }
        public int? Author3Id { get; set; }
        public int? TopicId { get; set; }
        public bool? BlockedFromRelease { get; set; }
        public bool IsEbattle { get; set; }
        public int SpecialtyId { get; set; }

        public Users Author { get; set; }
        public Users Author2 { get; set; }
        public Users Author3 { get; set; }
        public Poll Poll { get; set; }
        public Specialty Specialty { get; set; }
        public Topic Topic { get; set; }
        public ICollection<EfootprintContent> EfootprintContent { get; set; }
        public ICollection<EfootprintRefs> EfootprintRefs { get; set; }
    }
}
