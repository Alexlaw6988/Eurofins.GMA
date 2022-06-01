using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;
namespace Eurofins.GMA.Application.Mappers.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Eurofins.GMA.Domain.Entities.User, UserDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(m => m.Id))
                .ForMember(x => x.DepartmentId, opt => opt.MapFrom(m => m.DepartmentId))
                .ForMember(x => x.UserName, opt => opt.MapFrom(m => m.UserName))
                .ForMember(x => x.Email, opt => opt.MapFrom(m => m.Email));
        }
    }
}
