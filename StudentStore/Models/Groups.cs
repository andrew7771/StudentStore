using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Groups
    {
        public Groups()
        {
            GroupSubjects = new HashSet<GroupSubjects>();
            Students = new HashSet<Students>();
            SubjectCpgroups = new HashSet<SubjectCpgroups>();
        }

        public string GroupId { get; set; }
        public int CourseNumber { get; set; }

        public virtual ICollection<GroupSubjects> GroupSubjects { get; set; }
        public virtual ICollection<Students> Students { get; set; }
        public virtual ICollection<SubjectCpgroups> SubjectCpgroups { get; set; }
    }
}
