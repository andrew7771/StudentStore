using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public partial class Subject
    {
        public Subject()
        {
            AttendanceDates = new HashSet<AttendanceDate>();
            Attendances = new HashSet<Attendance>();
            FreeMarkFieldMaxPoints = new HashSet<FreeMarkFieldMaxPoint>();
            FreeMarkFields = new HashSet<FreeMarkField>();
            GroupSubjects = new HashSet<GroupSubjects>();
            HomeWorks = new HashSet<HomeWorks>();
            HwmaxPoints = new HashSet<HwmaxPoint>();
            LabMaxPoints = new HashSet<LabMaxPoint>();
            Marks = new HashSet<Mark>();
            ModuleMaxPoints = new HashSet<ModuleMaxPoint>();
            Modules = new HashSet<Module>();
            OneItemPoints = new HashSet<OneItemPoint>();
        }

        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string SubjectName { get; set; }
        public int Term { get; set; }
        public int SubjectType { get; set; }
        public string StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<AttendanceDate> AttendanceDates { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<FreeMarkFieldMaxPoint> FreeMarkFieldMaxPoints { get; set; }
        public virtual ICollection<FreeMarkField> FreeMarkFields { get; set; }
        public virtual ICollection<GroupSubjects> GroupSubjects { get; set; }
        public virtual ICollection<HomeWorks> HomeWorks { get; set; }
        public virtual ICollection<HwmaxPoint> HwmaxPoints { get; set; }
        public virtual ICollection<LabMaxPoint> LabMaxPoints { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<ModuleMaxPoint> ModuleMaxPoints { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<OneItemPoint> OneItemPoints { get; set; }
    }
}
