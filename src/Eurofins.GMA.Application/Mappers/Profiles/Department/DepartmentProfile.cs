using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;

namespace Eurofins.GMA.Application.Mappers.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Eurofins.GMA.Domain.Entities.Department, DepartmentDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(m => m.Id))
                .ForMember(x => x.DepartmentName, opt => opt.MapFrom(m => m.DepartmentName));
        }
    }
    
}
