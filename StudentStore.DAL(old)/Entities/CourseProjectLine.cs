using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class CourseProjectLine
    {
        public int Id { get; set; }
        public string LineName { get; set; }
        public int LineIndex { get; set; }
        public string StudentId { get; set; }
        public int SubjectCpId { get; set; }
        public int TheMark { get; set; }
        public DateTime DateOfPassing { get; set; }

        public virtual Student Student { get; set; }
        public virtual SubjectCp SubjectCp { get; set; }
    }
}
