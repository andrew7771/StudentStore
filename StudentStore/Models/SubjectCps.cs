using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class SubjectCps
    {
        public SubjectCps()
        {
            CourseProjectLines = new HashSet<CourseProjectLines>();
            CplineMaxPoints = new HashSet<CplineMaxPoints>();
            SubjectCpgroups = new HashSet<SubjectCpgroups>();
            SubjectCpstudents = new HashSet<SubjectCpstudents>();
        }

        public int SubjectCpId { get; set; }
        public int TeacherId { get; set; }
        public string SubjectCpname { get; set; }
        public int Term { get; set; }

        public virtual Teachers Teacher { get; set; }
        public virtual ICollection<CourseProjectLines> CourseProjectLines { get; set; }
        public virtual ICollection<CplineMaxPoints> CplineMaxPoints { get; set; }
        public virtual ICollection<SubjectCpgroups> SubjectCpgroups { get; set; }
        public virtual ICollection<SubjectCpstudents> SubjectCpstudents { get; set; }
    }
}
