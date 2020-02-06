using StudentStore.Models;
using StudentStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore.Repositories.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IEnumerable<Student> _inMemoryStudents;

        public StudentRepository()
        {
            _inMemoryStudents = new List<Student>
            {
                new Student("Vasya Pupkin"),
                new Student("Andrii Turianskyi"),
                new Student("Sergii Kovach")
            };
        }

        public IEnumerable<Student> GetAllStudents() => _inMemoryStudents;

        public Student GetStudentById(string id) => _inMemoryStudents.FirstOrDefault(student => student.Id == id);
    }
}
