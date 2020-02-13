using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Attendances
    {
        public int AttendanceId { get; set; }
        public string RecordBookNumberId { get; set; }
        public int SubjectId { get; set; }
        public DateTime ClassDate { get; set; }
        public bool IsVisited { get; set; }
        public int Index { get; set; }

        public virtual Student RecordBookNumber { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
