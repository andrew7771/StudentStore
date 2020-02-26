using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class HomeWorks
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Hwpoint { get; set; }
        public int Hwnumber { get; set; }
        public DateTime DateOfReport { get; set; }
        public DateTime DateOfProgram { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
