using Float.Application.Interfaces;
using Float.Infrastracture.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Float.Infrastracture.Persistence.Repositories
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GenericRepositoryAsync(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public virtual async Task<T> FindById(int id)
        {
            return await _applicationDbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAllItemAsync()
        {
            return await _applicationDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _applicationDbContext.Set<T>().AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _applicationDbContext.Set<T>().Remove(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _applicationDbContext.Entry(entity).State = EntityState.Modified;
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
