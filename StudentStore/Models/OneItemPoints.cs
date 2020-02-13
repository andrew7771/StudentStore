using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class OneItemPoints
    {
        public int OneItemPointId { get; set; }
        public string Value { get; set; }
        public int SubjectId { get; set; }

        public virtual Subjects Subject { get; set; }
    }
}
