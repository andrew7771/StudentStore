using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class OneItemPoint
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
