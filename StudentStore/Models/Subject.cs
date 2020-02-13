using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Subject
    {
        public Subject()
        {
            AttendanceDates = new HashSet<AttendanceDates>();
            Attendances = new HashSet<Attendances>();
            FreeMarkFieldMaxPoints = new HashSet<FreeMarkFieldMaxPoints>();
            FreeMarkFields = new HashSet<FreeMarkFields>();
            GroupSubjects = new HashSet<GroupSubjects>();
            HomeWorks = new HashSet<HomeWorks>();
            HwmaxPoints = new HashSet<HwmaxPoints>();
            LabMaxPoints = new HashSet<LabMaxPoints>();
            Marks = new HashSet<Marks>();
            ModuleMaxPoints = new HashSet<ModuleMaxPoints>();
            Modules = new HashSet<Modules>();
            OneItemPoints = new HashSet<OneItemPoints>();
        }

        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string SubjectName { get; set; }
        public int Term { get; set; }
        public int SubjectType { get; set; }
        public string StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<AttendanceDates> AttendanceDates { get; set; }
        public virtual ICollection<Attendances> Attendances { get; set; }
        public virtual ICollection<FreeMarkFieldMaxPoints> FreeMarkFieldMaxPoints { get; set; }
        public virtual ICollection<FreeMarkFields> FreeMarkFields { get; set; }
        public virtual ICollection<GroupSubjects> GroupSubjects { get; set; }
        public virtual ICollection<HomeWorks> HomeWorks { get; set; }
        public virtual ICollection<HwmaxPoints> HwmaxPoints { get; set; }
        public virtual ICollection<LabMaxPoints> LabMaxPoints { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
        public virtual ICollection<ModuleMaxPoints> ModuleMaxPoints { get; set; }
        public virtual ICollection<Modules> Modules { get; set; }
        public virtual ICollection<OneItemPoints> OneItemPoints { get; set; }
    }
}
