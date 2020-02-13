using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class SubjectCpgroups
    {
        public int SubjectCpSubjectCpId { get; set; }
        public string GroupGroupId { get; set; }

        public virtual Groups GroupGroup { get; set; }
        public virtual SubjectCps SubjectCpSubjectCp { get; set; }
    }
}
