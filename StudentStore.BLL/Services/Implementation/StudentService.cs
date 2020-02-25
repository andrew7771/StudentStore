using StudentStore.DAL.Entities;
using StudentStore.Repositories.Interfaces;
using StudentStore.BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentStore.BLL.ViewModels;
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

        public IEnumerable<StudentViewModel> GetAllStudents()
        {
            var result = _studentRepository.GetAllStudents();
            return _mapper.Map<IEnumerable<StudentViewModel>>(result);
        }

        public StudentViewModel GetStudentById(string id)
        {
            var result = _studentRepository.GetStudentById(id);
            return _mapper.Map<StudentViewModel>(result);
        }
    }
}
