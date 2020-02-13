using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class HwmaxPoints
    {
        public int HwmaxPointId { get; set; }
        public int SubjectId { get; set; }
        public int Hwnumber { get; set; }
        public int MaxPoint { get; set; }

        public virtual Subjects Subject { get; set; }
    }
}
