using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class LabMaxPoint
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int LabNumber { get; set; }
        public int MaxPoint { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
