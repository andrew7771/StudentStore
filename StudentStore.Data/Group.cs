using System.Collections.Generic;

namespace StudentStore.Data.Entities
{
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
            SubjectGroups = new HashSet<SubjectGroup>();
        }

        public string Id { get; set; }
        public int CourseNumber { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<SubjectGroup> SubjectGroups { get; set; }
    }
}
