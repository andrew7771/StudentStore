using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class SubjectCp
    {
        public SubjectCp()
        {
            CourseProjectLines = new HashSet<CourseProjectLine>();
            CplineMaxPoints = new HashSet<CplineMaxPoint>();
            SubjectCpgroups = new HashSet<SubjectCpGroup>();
            SubjectCpstudents = new HashSet<SubjectCpstudent>();
        }

        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string SubjectCpname { get; set; }
        public int Term { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual ICollection<CplineMaxPoint> CplineMaxPoints { get; set; }
        public virtual ICollection<SubjectCpGroup> SubjectCpgroups { get; set; }
        public virtual ICollection<SubjectCpstudent> SubjectCpstudents { get; set; }
    }
}
