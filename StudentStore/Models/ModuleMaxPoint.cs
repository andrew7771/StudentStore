using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class ModuleMaxPoint
    {
        public int Id { get; set; }
        public int ModuleNumber { get; set; }
        public int MaxPoint { get; set; }

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
