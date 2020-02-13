using System;
using System.Collections.Generic;

namespace StudentStore.Models
{
    public partial class Teachers
    {
        public Teachers()
        {
            SubjectCps = new HashSet<SubjectCps>();
            Subjects = new HashSet<Subjects>();
        }

        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AcadDegree { get; set; }

        public virtual ICollection<SubjectCps> SubjectCps { get; set; }
        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
