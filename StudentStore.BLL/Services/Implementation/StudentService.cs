using StudentStore.Data.Entities;
using StudentStore.Repositories.Interfaces;
using StudentStore.BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentStore.BLL.Models;
using AutoMapper;

namespace StudentStore.BLL.Services.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public IEnumerable<StudentModel> GetAllStudents()
        {
            var result = _studentRepository.GetAllStudents();
            return _mapper.Map<IEnumerable<StudentModel>>(result);
        }

        public StudentModel GetStudentById(string id)
        {
            var result = _studentRepository.GetStudentById(id);
            return _mapper.Map<StudentModel>(result);
        }
    }
}
