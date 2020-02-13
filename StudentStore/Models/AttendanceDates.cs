using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class AttendanceDates
    {
        public int AttendanceDateId { get; set; }
        public DateTime Date { get; set; }
        public int Index { get; set; }
        public int SubjectId { get; set; }

        public virtual Subjects Subject { get; set; }
    }
}
