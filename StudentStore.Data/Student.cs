using System;
using System.Collections.Generic;

namespace StudentStore.Data.Entities
{
    public class Student
    {
        public Student()
        {
            
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string GroupId { get; set; }
        public virtual Group Group { get; set; }       
    }
}
