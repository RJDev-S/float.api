using Float.Application.DTOs.Account;
using System.Threading.Tasks;

namespace Float.Application.Interfaces
{
    public interface ISignupService
    {
        Task<string> AddUserinDb(UserAccountDTO newUser);
    }
}
