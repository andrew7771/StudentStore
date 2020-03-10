using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class CplineMaxPoint
    {
        public int Id { get; set; }
        public int SubjectCpid { get; set; }
        public string LineName { get; set; }
        public int LineIndex { get; set; }
        public int MaxPoint { get; set; }
        public int? SubjectCpId { get; set; }

        public virtual SubjectCp SubjectCp { get; set; }
    }
}
