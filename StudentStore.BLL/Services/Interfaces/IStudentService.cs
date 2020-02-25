using StudentStore.BLL.ViewModels;
using StudentStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore.BLL.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentViewModel> GetAllStudents();
        StudentViewModel GetStudentById(string id);
    }
}
