using AutoMapper;
using SchoolManagementSystem.API.Data.Models.Entities;
using SchoolManagementSystem.API.Dtos;

namespace SchoolManagementSystem.API.Helpers.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentsToReturnDto>(); 
            CreateMap<StudentsForReturnDto, Student>();
           
        }
    }
}