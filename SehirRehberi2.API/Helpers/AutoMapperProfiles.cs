using AutoMapper;
using SehirRehberi2.API.Dtos;
using SehirRehberi2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SehirRehberi2.API.Dtos;

namespace SehirRehberi2.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                .ForMember(dest=> dest.PhotoUrl,opt=>
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                });

            CreateMap<City, CityForDetailDto>();

            CreateMap<PhotoForCreationDto,Photo>();
            CreateMap<PhotoForReturnDto, Photo >();
        }


    }
}
