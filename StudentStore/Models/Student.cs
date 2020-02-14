using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            CourseProjectLines = new HashSet<CourseProjectLine>();
            FreeMarkFields = new HashSet<FreeMarkField>();
            HomeWorks = new HashSet<HomeWorks>();
            Marks = new HashSet<Mark>();
            Modules = new HashSet<Module>();
            SubjectCpstudents = new HashSet<SubjectCpstudent>();
            Subjects = new HashSet<Subject>();
        }

        public string Id { get; set; }
        public string GroupId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual ICollection<FreeMarkField> FreeMarkFields { get; set; }
        public virtual ICollection<HomeWorks> HomeWorks { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<SubjectCpstudent> SubjectCpstudents { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
