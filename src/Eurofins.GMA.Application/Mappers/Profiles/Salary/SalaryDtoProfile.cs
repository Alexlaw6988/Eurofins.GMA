using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;

namespace Eurofins.GMA.Application.Mappers.Profiles
{
    public class SalaryDtoProfile : Profile
    {
        public SalaryDtoProfile()
        {
            CreateMap<Eurofins.GMA.Domain.Entities.Salary, SalaryDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(m => m.Id))
                .ForMember(x => x.UserId, opt => opt.MapFrom(m => m.UserId))
                .ForMember(x => x.CoefficientsSalary, opt => opt.MapFrom(m => m.CoefficientsSalary))
                .ForMember(x => x.WorkDays, opt => opt.MapFrom(m => m.WorkDays))
                .ForMember(x => x.TotalSalary, opt => opt.MapFrom(m => m.TotalSalary));
        }
    }   
}
