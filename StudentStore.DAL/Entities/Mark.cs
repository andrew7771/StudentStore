using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class Mark
    {
        public int Id { get; set; }
        public int LabNumber { get; set; }
        public string StudentId { get; set; }
        public int SubjectId { get; set; }
        public DateTime DateOfReport { get; set; }
        public DateTime DateOfProgram { get; set; }
        public int TheMark { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
