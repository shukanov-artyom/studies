using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Subspecialty
    {
        public Subspecialty()
        {
            AuthorsTeam = new HashSet<AuthorsTeam>();
            Case = new HashSet<Case>();
            Clusters = new HashSet<Clusters>();
            Field = new HashSet<Field>();
            Group = new HashSet<Group>();
            Post = new HashSet<Post>();
            Procedure = new HashSet<Procedure>();
            StudyPlanDayPrimarySpecialty = new HashSet<StudyPlanDay>();
            StudyPlanDaySecondarySpecialty = new HashSet<StudyPlanDay>();
            TechniqueMap = new HashSet<TechniqueMap>();
            Topic = new HashSet<Topic>();
            TopicSection = new HashSet<TopicSection>();
            Video = new HashSet<Video>();
        }

        public int SubspecialtyId { get; set; }
        public int SpecialtyId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int Sortorder { get; set; }
        public int GroupingKey { get; set; }
        public string ShortName { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<AuthorsTeam> AuthorsTeam { get; set; }
        public ICollection<Case> Case { get; set; }
        public ICollection<Clusters> Clusters { get; set; }
        public ICollection<Field> Field { get; set; }
        public ICollection<Group> Group { get; set; }
        public ICollection<Post> Post { get; set; }
        public ICollection<Procedure> Procedure { get; set; }
        public ICollection<StudyPlanDay> StudyPlanDayPrimarySpecialty { get; set; }
        public ICollection<StudyPlanDay> StudyPlanDaySecondarySpecialty { get; set; }
        public ICollection<TechniqueMap> TechniqueMap { get; set; }
        public ICollection<Topic> Topic { get; set; }
        public ICollection<TopicSection> TopicSection { get; set; }
        public ICollection<Video> Video { get; set; }
    }
}
