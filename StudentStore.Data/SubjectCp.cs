using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStore.Data.Entities
{
    public class SubjectCp
    {
        public SubjectCp()
        {
            
        }

        public int Id { get; set; }
        public string SubjectCpname { get; set; }
        public int Term { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
      
    }
}
