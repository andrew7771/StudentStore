using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class SubjectCpGroup
    {
        public int SubjectCpId { get; set; }
        public string GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual SubjectCp SubjectCp { get; set; }
    }
}
