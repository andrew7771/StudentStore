using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class SubjectCpstudents
    {
        public int SubjectCpSubjectCpId { get; set; }
        public string StudentRecordBookNumberId { get; set; }

        public virtual Students StudentRecordBookNumber { get; set; }
        public virtual SubjectCps SubjectCpSubjectCp { get; set; }
    }
}
