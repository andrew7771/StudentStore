﻿using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class FreeMarkFieldMaxPoints
    {
        public int FreeMarkFieldMaxPointId { get; set; }
        public int FieldNumber { get; set; }
        public string FieldName { get; set; }
        public int MaxPoint { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
