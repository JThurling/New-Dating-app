using System.Linq;
using AutoMapper;
using DatingSite.DTOs;
using DatingSite.Models;

namespace DatingSite.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForList>()
                .ForMember(dest => dest.PhotoUrl, opt => 
                    opt.MapFrom(src =>
                    src.Photos.FirstOrDefault(p => p.IsMain).Url
                    ))
                .ForMember(dest => dest.Age, opt =>
                    opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<User, UserForDetails>()
                .ForMember(dest => dest.PhotoUrl, opt => 
                    opt.MapFrom(src =>
                        src.Photos.FirstOrDefault(p => p.IsMain).Url
                    ))
                .ForMember(dest => dest.Age, opt =>
                    opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Photo, PhotosForDetails>();
        }
    }
}