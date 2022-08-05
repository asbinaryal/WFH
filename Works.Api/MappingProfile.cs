using AutoMapper;
using Works.Data.Entities;
using Works.Models;

namespace Works.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
        }
    }
}
