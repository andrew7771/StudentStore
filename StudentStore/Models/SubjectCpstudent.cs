using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class SubjectCpstudent
    {
        public int Id { get; set; }
        public string StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual SubjectCp SubjectCpSubjectCp { get; set; }
    }
}
