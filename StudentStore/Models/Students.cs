using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Students
    {
        public Students()
        {
            Attendances = new HashSet<Attendances>();
            CourseProjectLines = new HashSet<CourseProjectLines>();
            FreeMarkFields = new HashSet<FreeMarkFields>();
            HomeWorks = new HashSet<HomeWorks>();
            Marks = new HashSet<Marks>();
            Modules = new HashSet<Modules>();
            SubjectCpstudents = new HashSet<SubjectCpstudents>();
            Subjects = new HashSet<Subjects>();
        }

        public string RecordBookNumberId { get; set; }
        public string GroupId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public virtual Groups Group { get; set; }
        public virtual ICollection<Attendances> Attendances { get; set; }
        public virtual ICollection<CourseProjectLines> CourseProjectLines { get; set; }
        public virtual ICollection<FreeMarkFields> FreeMarkFields { get; set; }
        public virtual ICollection<HomeWorks> HomeWorks { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
        public virtual ICollection<Modules> Modules { get; set; }
        public virtual ICollection<SubjectCpstudents> SubjectCpstudents { get; set; }
        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
