using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class SubjectCp
    {
        public SubjectCp()
        {
            CourseProjectLines = new HashSet<CourseProjectLines>();
            CplineMaxPoints = new HashSet<CplineMaxPoints>();
            SubjectCpgroups = new HashSet<SubjectCpGroup>();
            SubjectCpstudents = new HashSet<SubjectCpstudent>();
        }

        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string SubjectCpname { get; set; }
        public int Term { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<CourseProjectLines> CourseProjectLines { get; set; }
        public virtual ICollection<CplineMaxPoints> CplineMaxPoints { get; set; }
        public virtual ICollection<SubjectCpGroup> SubjectCpgroups { get; set; }
        public virtual ICollection<SubjectCpstudent> SubjectCpstudents { get; set; }
    }
}
