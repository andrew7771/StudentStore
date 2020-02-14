using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Module
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int SubjectId { get; set; }
        public int ModulePoint { get; set; }
        public int ModuleNumber { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
