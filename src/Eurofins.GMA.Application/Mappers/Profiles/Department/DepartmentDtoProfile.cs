using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;

namespace Eurofins.GMA.Application.Mappers.Profiles
{
    public class DepartmentDtoProfile : Profile
    {
        public DepartmentDtoProfile()
        {
            CreateMap<DepartmentDto, Eurofins.GMA.Domain.Entities.Department>()
                .ForMember(x => x.Id, opt => opt.MapFrom(m => m.Id))
                .ForMember(x => x.DepartmentName, opt => opt.MapFrom(m => m.DepartmentName));
        }
    }
}
