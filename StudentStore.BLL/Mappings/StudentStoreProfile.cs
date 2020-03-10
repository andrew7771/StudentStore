using AutoMapper;
using Microsoft.AspNetCore.Identity;
using StudentStore.BLL.Models;
using StudentStore.Data.Entities;
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
            CreateMap<Student, StudentModel>().ReverseMap();
            CreateMap<Group, GroupModel>().ReverseMap();
            CreateMap<User, RegisterModel>().ReverseMap();
            CreateMap<IdentityError, ErrorModel>();
        }
    }
}
