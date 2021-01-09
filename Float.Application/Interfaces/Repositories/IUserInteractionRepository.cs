using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Float.Application.Interfaces.Repositories
{
    public interface IUserInteractionRepository<T> where T : class
    {
        Task<T> FindByUsername(string username);
    }
}
