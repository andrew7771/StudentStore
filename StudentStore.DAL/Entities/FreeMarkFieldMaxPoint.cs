using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class FreeMarkFieldMaxPoint
    {
        public int Id { get; set; }
        public int FieldNumber { get; set; }
        public string FieldName { get; set; }
        public int MaxPoint { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
