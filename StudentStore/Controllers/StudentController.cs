using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentStore.DAL.Entities;
using StudentStore.BLL.Services.Interfaces;
using StudentStore.BLL.ViewModels;

namespace StudentStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public IEnumerable<StudentViewModel> GetAllStudents() => _studentService.GetAllStudents().ToList();
    }
}