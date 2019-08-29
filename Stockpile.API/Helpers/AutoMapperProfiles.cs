using System.Linq;
using AutoMapper;
using Stockpile.API.Dtos;
using Stockpile.API.Models;

namespace Stockpile.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>().ForMember(dest => dest.PhotoUrl, opt =>
            {
                opt.MapFrom(src => src.Photo.FirstOrDefault(p => p.isMain).Url);
            })
            .ForMember(dest => dest.AccountAge, opt => {
               opt.MapFrom((s,d) => s.AccountCreated.CalculateAge());
            });

            CreateMap<User, UserForDetailDto>()
          .ForMember(dest => dest.PhotoUrl, opt =>
          {
              opt.MapFrom(src => src.Photo.FirstOrDefault(p => p.isMain).Url);
          })
          .ForMember(dest => dest.AccountAge, opt => {
               opt.MapFrom((s,d) => s.AccountCreated.CalculateAge());
          });

            CreateMap<Inventory, InventoryListDto>();
            CreateMap<Photo, PhotoForDetailDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<Photo, PhotoToReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<UserForRegisterDto, User>();
        }

    }
}