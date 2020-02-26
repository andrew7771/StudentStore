using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class FreeMarkField
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        public int FieldNumber { get; set; }
        public string StudentId { get; set; }
        public int SubjectId { get; set; }
        public int FieldPoint { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
