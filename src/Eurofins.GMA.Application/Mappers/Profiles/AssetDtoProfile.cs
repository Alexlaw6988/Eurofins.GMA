using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Domain.Entities;

namespace Eurofins.GMA.Application.Mappers.Profiles
{
    public class AssetDtoProfile : Profile
    {
        public AssetDtoProfile()
        {
            CreateMap<AssetDto, Asset>()
                .ForMember(x => x.Id, opt => opt.MapFrom(m => m.Id))
                .ForMember(x => x.AssetId, opt => opt.MapFrom(m => m.AssetId))
                .ForMember(x => x.FileName, opt => opt.MapFrom(m => m.FileName))
                .ForMember(x => x.MimeType, opt => opt.MapFrom(m => m.MimeType))
                .ForMember(x => x.Country, opt => opt.MapFrom(m => m.Country))
                .ForMember(x => x.CreatedBy, opt => opt.MapFrom(m => m.CreatedBy))
                .ForMember(x => x.Description, opt => opt.MapFrom(m => m.Description))
                .ForMember(x => x.Email, opt => opt.MapFrom(m => m.Email));
        }
    }
}
