﻿using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            SubjectCps = new HashSet<SubjectCp>();
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AcadDegree { get; set; }

        public virtual ICollection<SubjectCp> SubjectCps { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
