using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Groups
    {
        public Groups()
        {
            GroupSubjects = new HashSet<GroupSubjects>();
            Students = new HashSet<Student>();
            SubjectCpgroups = new HashSet<SubjectCpGroup>();
        }

        public string GroupId { get; set; }
        public int CourseNumber { get; set; }

        public virtual ICollection<GroupSubjects> GroupSubjects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<SubjectCpGroup> SubjectCpgroups { get; set; }
    }
}
