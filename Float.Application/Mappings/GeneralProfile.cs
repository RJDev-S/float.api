using AutoMapper;
using Float.Application.DTOs.Account;
using Float.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            //CreateMap<RegisterRequest, UserAccount>().ReverseMap();
        }
    }
}
