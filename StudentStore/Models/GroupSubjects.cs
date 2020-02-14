﻿using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class GroupSubjects
    {
        public string GroupId { get; set; }
        public int SubjectId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
