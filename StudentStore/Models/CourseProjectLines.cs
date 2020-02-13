using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class CourseProjectLines
    {
        public int CourseProjectLineId { get; set; }
        public string LineName { get; set; }
        public int LineIndex { get; set; }
        public string RecordBookNumberId { get; set; }
        public int SubjectCpId { get; set; }
        public int TheMark { get; set; }
        public DateTime DateOfPassing { get; set; }

        public virtual Students RecordBookNumber { get; set; }
        public virtual SubjectCps SubjectCp { get; set; }
    }
}
