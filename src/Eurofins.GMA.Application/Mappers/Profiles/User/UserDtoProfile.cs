using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;

namespace Eurofins.GMA.Application.Mappers.Profiles
{
    public class UserDtoProfile : Profile
    {
        public UserDtoProfile()
        {
            CreateMap<UserDto, Eurofins.GMA.Domain.Entities.User>()
                .ForMember(x => x.Id, opt => opt.MapFrom(m => m.Id))
                .ForMember(x => x.Email, opt => opt.MapFrom(m => m.Email))
                .ForMember(x => x.UserName, opt => opt.MapFrom(m => m.UserName))
                .ForMember(x => x.DepartmentId, opt => opt.MapFrom(m => m.DepartmentId));
        }
    }
}
