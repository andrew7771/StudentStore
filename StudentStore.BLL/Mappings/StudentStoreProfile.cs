using AutoMapper;
using StudentStore.BLL.ViewModels;
using StudentStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStore.BLL.Mappings
{
    public class StudentStoreProfile : Profile
    {
        public StudentStoreProfile()
        {
            CreateMap<Student, StudentViewModel>().ReverseMap();
            CreateMap<Group, GroupViewModel>().ReverseMap();
        }
    }
}
