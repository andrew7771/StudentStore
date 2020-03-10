using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStore.DAL.Entities
{
    public class Subject
    {
        public Subject()
        {
            SubjectGroups = new HashSet<SubjectGroup>();
        }
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public virtual ICollection<SubjectGroup> SubjectGroups { get; set; }
    }
}
