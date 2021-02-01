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
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountService(IMapper mapper, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<Response<string>> ResetPasswordAsync(ResetPasswordRequest model)
        {
            var account = await _userManager.FindByNameAsync(model.Username);

            if (account == null)
            {
                throw new ApiException($"Account does not exist.");
            }

            string resultToken = await _userManager.GeneratePasswordResetTokenAsync(account);

            var response = await _userManager.ResetPasswordAsync(account, resultToken, model.NewPassword);

            if (response.Succeeded)
            {
                return new Response<string>("Successfuly changed your password");
            }
            else
            {
                throw new ApiException("An error occured while changing your password.");
            }
        }

        public async Task<Response<LoginResponse>> AuthenticateAsync(LoginRequest model)
        {
            var account = await _userManager.FindByNameAsync(model.Username);

            if (account == null)
            {
                throw new ApiException("Wrong username or password");
            }

            var result = await _signInManager.PasswordSignInAsync(account.UserName, model.Password, isPersistent: false, lockoutOnFailure: false);


            if (!result.Succeeded)
            {
                throw new ApiException("Wrong username or password");
            }

            LoginResponse loginResponse = new LoginResponse();
            loginResponse.Username = model.Username;
            loginResponse.Password = model.Password;
            loginResponse.IsVerified = true;
            return new Response<LoginResponse>(loginResponse, $"Authenticated Successfuly");
        }

        public async Task<Response<string>> RegisterAsync(RegisterRequest request)
        {
            var usernameWithSameUsername = await _userManager.FindByNameAsync(request.Username);

            if (usernameWithSameUsername != null)
            {
                throw new ApiException($"Username {request.Username} is already taken.");
            }

            var account = new ApplicationUser()
            {
                UserName = request.Username,
                DateCreated = DateTime.Now.ToString("dddd, dd/MM/yyyy - hh:mm tt")
            };

            try
            {
                var result = await _userManager.CreateAsync(account, request.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        throw new ApiException(error.Description);
                    }
                }
                return new Response<string>($"Successfuly created your account.", true);
            }
            catch (AggregateException e) 
            { }

            return null;
        }
    }
}
