using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class HomeWorks
    {
        public int HomeWorkId { get; set; }
        public string RecordBookNumberId { get; set; }
        public int SubjectId { get; set; }
        public int Hwpoint { get; set; }
        public int Hwnumber { get; set; }
        public DateTime DateOfReport { get; set; }
        public DateTime DateOfProgram { get; set; }

        public virtual Student RecordBookNumber { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
