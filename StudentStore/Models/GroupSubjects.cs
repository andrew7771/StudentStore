using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class GroupSubjects
    {
        public string GroupGroupId { get; set; }
        public int SubjectSubjectId { get; set; }

        public virtual Groups GroupGroup { get; set; }
        public virtual Subjects SubjectSubject { get; set; }
    }
}
