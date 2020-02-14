using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Group
    {
        public Group()
        {
            GroupSubjects = new HashSet<GroupSubjects>();
            Students = new HashSet<Student>();
            SubjectCpgroups = new HashSet<SubjectCpGroup>();
        }

        public string Id { get; set; }
        public int CourseNumber { get; set; }

        public virtual ICollection<GroupSubjects> GroupSubjects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<SubjectCpGroup> SubjectCpgroups { get; set; }
    }
}
