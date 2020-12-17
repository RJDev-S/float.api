using Float.Core.Dto;
using Float.Core.Model;
using Float.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Float.Core.Interfaces
{
    public interface ISignupService
    {
         Task<ServiceResponse<Signup>> AddUserinDb(SignupDto newUser);
    }
}
