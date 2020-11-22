﻿using AutoMapper;
using sites4u.Dtos;
using sites4u.Entities;
using sites4u.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sites4u.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                 .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                  src.Photos.FirstOrDefault(x => x.IsMain).Url))
                 .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>();
        }
    }
}
