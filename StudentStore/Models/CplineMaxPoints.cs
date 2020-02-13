using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class CplineMaxPoints
    {
        public int CplineMaxPointId { get; set; }
        public int SubjectCpid { get; set; }
        public string LineName { get; set; }
        public int LineIndex { get; set; }
        public int MaxPoint { get; set; }
        public int? SubjectCpSubjectCpId { get; set; }

        public virtual SubjectCps SubjectCpSubjectCp { get; set; }
    }
}
