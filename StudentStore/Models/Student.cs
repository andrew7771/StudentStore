using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Student()
        {

        }
        public Student(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        
    }
}
