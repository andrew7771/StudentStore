using StudentStore.Models;
using StudentStore.Repositories.Interfaces;
using StudentStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore.Services.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudents() => _studentRepository.GetAllStudents();

        public Student GetStudentById(string id) => _studentRepository.GetStudentById(id);
    }
}
