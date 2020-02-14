using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class HwmaxPoint
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int Hwnumber { get; set; }
        public int MaxPoint { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
