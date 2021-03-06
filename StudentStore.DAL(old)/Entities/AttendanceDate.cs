﻿using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class AttendanceDate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Index { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
