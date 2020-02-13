using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Modules
    {
        public int ModuleId { get; set; }
        public string RecordBookNumberId { get; set; }
        public int SubjectId { get; set; }
        public int ModulePoint { get; set; }
        public int ModuleNumber { get; set; }

        public virtual Students RecordBookNumber { get; set; }
        public virtual Subjects Subject { get; set; }
    }
}
