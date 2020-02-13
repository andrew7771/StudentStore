using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class FreeMarkFields
    {
        public int FreeMarkFieldId { get; set; }
        public string FieldName { get; set; }
        public int FieldNumber { get; set; }
        public string RecordBookNumberId { get; set; }
        public int SubjectId { get; set; }
        public int FieldPoint { get; set; }

        public virtual Students RecordBookNumber { get; set; }
        public virtual Subjects Subject { get; set; }
    }
}
