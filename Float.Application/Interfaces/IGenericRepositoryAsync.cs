using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Float.Application.Interfaces
{
   public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<T> FindById(int id);
        Task<IReadOnlyList<T>> GetAllItemAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
