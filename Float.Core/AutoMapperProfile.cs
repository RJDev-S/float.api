using AutoMapper;
using Float.Core.Dto;
using Float.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Core
{
    class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<SignupDto, Signup>().ForMember(dest => dest.Passwords, opt => opt.MapFrom(src => src.Password));
        }
    }
}
