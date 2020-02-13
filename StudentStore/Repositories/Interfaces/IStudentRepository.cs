using StudentStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Students> GetAllStudents();
        Students GetStudentById(string id);
    }
}
