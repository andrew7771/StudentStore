using System;
using System.Collections.Generic;

namespace StudentStore.DAL.Models
{
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public string Id { get; set; }
        public int CourseNumber { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
