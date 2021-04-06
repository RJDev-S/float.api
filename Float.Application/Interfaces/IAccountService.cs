using Float.Application.DTOs.Account;
using Float.Application.Wrappers;
using System.Threading.Tasks;

namespace Float.Application.Interfaces
{
    public interface IAccountService
    {
        Task<Response<RegisterResponse>> RegisterAsync(RegisterRequest registerRequest);
        Task<Response<LoginResponse>> AuthenticateAsync(LoginRequest registerRequest);
        Task<Response<string>> ResetPasswordAsync(ResetPasswordRequest changePasswordRequest);
    }
}
