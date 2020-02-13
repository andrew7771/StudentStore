using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Marks
    {
        public int MarkId { get; set; }
        public int LabNumber { get; set; }
        public string RecordBookNumberId { get; set; }
        public int SubjectId { get; set; }
        public DateTime DateOfReport { get; set; }
        public DateTime DateOfProgram { get; set; }
        public int TheMark { get; set; }

        public virtual Student RecordBookNumber { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
