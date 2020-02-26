using StudentStore.BLL.Models;
using StudentStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore.BLL.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentModel> GetAllStudents();
        StudentModel GetStudentById(string id);
    }
}
