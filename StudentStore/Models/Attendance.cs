using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Attendance
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int SubjectId { get; set; }
        public DateTime ClassDate { get; set; }
        public bool IsVisited { get; set; }
        public int Index { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
