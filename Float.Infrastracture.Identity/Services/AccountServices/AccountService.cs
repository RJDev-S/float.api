using AutoMapper;
using Float.Application.DTOs.Account;
using Float.Application.Exceptions;
using Float.Application.Interfaces;
using Float.Application.Interfaces.Repositories;
using Float.Application.Wrappers;
using Float.Infrastracture.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Float.Application.Services.AccountServices
{
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountService(IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<Response<string>> RegisterAsync(RegisterRequest request)
        {
            var usernameWithSameUsername = await _userManager.FindByNameAsync(request.Username);
          
            if (usernameWithSameUsername != null)
            {
                throw new APIException($"Username {request.Username} is already taken.");
            }

            var account = new ApplicationUser()
            {
                UserName = request.Username,
                DateCreated = DateTime.Now.ToString("dddd, dd/MM/yyyy - hh:mm tt")
            };

            try
            {
                var result = await _userManager.CreateAsync(account, request.Password);

                if(!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        throw new APIException(error.Description);
                    }
                }
                return new Response<string>(message: $"Successfuly created your account.");
            }
            catch (AggregateException e)
            {}

            return null;
        }
    }
}
