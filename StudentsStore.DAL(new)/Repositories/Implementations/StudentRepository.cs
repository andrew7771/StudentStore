using Microsoft.EntityFrameworkCore;
using StudentStore.DAL;
using StudentStore.DAL.Entities;
using StudentStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore.Repositories.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        StudentStoreContext _db;
        public StudentRepository(StudentStoreContext db)
        {
            _db = db;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            var res = _db.Students.Include(s => s.Group);
            return res;
        }

        public Student GetStudentById(string id) => _db.Students.FirstOrDefault(student => student.Id == id);
    }
}
