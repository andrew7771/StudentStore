using StudentStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(string id);
    }
}
