using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStore.Data.Entities
{
    public class SubjectGroup
    {
        public string GroupId { get; set; }
        public Group Book { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}
