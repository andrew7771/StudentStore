using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class ModuleMaxPoints
    {
        public int ModuleMaxPointId { get; set; }
        public int SubjectId { get; set; }
        public int ModuleNumber { get; set; }
        public int MaxPoint { get; set; }

        public virtual Subjects Subject { get; set; }
    }
}
