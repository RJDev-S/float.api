using AutoMapper;
using Float.Application.DTOs.Account;
using Float.Application.Interfaces;
using Float.Application.Interfaces.Repositories;
using Float.Application.Wrappers;
using System;
using System.Threading.Tasks;

namespace Float.Application.Services.AccountServices
{
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;
        private readonly IUserAccountRepository<UserAccountDTO> _repository;

        public AccountService(IMapper mapper, IUserAccountRepository<AccountService> repository)
        {
            _mapper = mapper;
            _repository = repository;
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

        public async Task<Response<UserAccountDTO>> CreateUserAccount(UserAccountDTO newUser)
        {


            var account = await _repository.FindByUsername(newUser.Username);

            return  new Response<UserAccountDTO>(account);
        }
    }
}
