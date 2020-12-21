using AutoMapper;
using Float.Core.Dto;
using Float.Core.Interfaces;
using Float.Core.Model;
using Float.Core.Models;
using System;
using System.Threading.Tasks;

namespace Float.Core.Services
{
    public class SignupService : ISignupService
    {
        private readonly IMapper _mapper;
        private Signup _signUp = new Signup();

        public SignupService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<Signup>> AddUserinDb(SignupDto newUser)
        {
            ServiceResponse<Signup> serviceResponseModel = new ServiceResponse<Signup>();
            try
            {
             ;
                serviceResponseModel.Data = _mapper.Map<Signup>(newUser);
                serviceResponseModel.IsSuccess = true;
                serviceResponseModel.Message = "Sign up successful!";

            }
            catch (Exception e)
            {
                serviceResponseModel.Data = null;
                serviceResponseModel.IsSuccess = false;
                serviceResponseModel.Message = e.Message;
            }

            return serviceResponseModel;
        }
    }
}
