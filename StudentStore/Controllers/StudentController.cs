using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentStore.DAL.Entities;
using StudentStore.BLL.Services.Interfaces;
using StudentStore.BLL.Models;
using Microsoft.AspNetCore.Authorization;

namespace StudentStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public IEnumerable<StudentModel> GetAllStudents() => _studentService.GetAllStudents().ToList();
    }
}