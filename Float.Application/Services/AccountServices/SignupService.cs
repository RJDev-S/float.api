using AutoMapper;
using Float.Application.DTOs.Account;
using Float.Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Float.Application.Services.AccountServices
{
    public class SignupService : ISignupService
    {
        private readonly IMapper _mapper;

        public SignupService(IMapper mapper)
        {
            _mapper = mapper;
        }

        //public async Task<ServiceResponse<Signup>> AddUserinDb(SignupDto newUser)
        //{
        //    ServiceResponse<Signup> serviceResponseModel = new ServiceResponse<Signup>();
        //    try
        //    {
        //     ;
        //        serviceResponseModel.Data = _mapper.Map<Signup>(newUser);
        //        serviceResponseModel.IsSuccess = true;
        //        serviceResponseModel.Message = "Sign up successful!";

        //    }
        //    catch (Exception e)
        //    {
        //        serviceResponseModel.Data = null;
        //        serviceResponseModel.IsSuccess = false;
        //        serviceResponseModel.Message = e.Message;
        //    }

        //    return serviceResponseModel;
        //}

        public async Task<string> AddUserinDb(UserAccountDTO newUser)
        {
            return "Go to this url to verify your account";
        }
    }
}
