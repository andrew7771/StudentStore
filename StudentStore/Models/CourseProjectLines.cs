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

        public virtual Student RecordBookNumber { get; set; }
        public virtual SubjectCp SubjectCp { get; set; }
    }
}
