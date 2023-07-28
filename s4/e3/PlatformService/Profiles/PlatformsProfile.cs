using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // source - > Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
            CreateMap<PlatformReadDto, PlatformPublishedDto>();
            CreateMap<Platform, GrpcPlatformModel>()
                    .ForMember(des => des.PlatformId, opt => opt.MapFrom(src => src.Id))
                    .ForMember(des => des.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(des => des.Publisher, opt => opt.MapFrom(src => src.Publisher));
        }
    }
}