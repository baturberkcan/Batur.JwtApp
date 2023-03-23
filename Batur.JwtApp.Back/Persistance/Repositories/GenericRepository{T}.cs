using Batur.JwtApp.Back.Core.Application.Interfaces;
using Batur.JwtApp.Back.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Batur.JwtApp.Back.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly BaturJwtContext _baturJwtContext;

        public Repository(BaturJwtContext baturJwtContext)
        {
            _baturJwtContext = baturJwtContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _baturJwtContext.Set<T>().AddAsync(entity);
            await _baturJwtContext.SaveChangesAsync();

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _baturJwtContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return await _baturJwtContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _baturJwtContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _baturJwtContext.Set<T>().Remove(entity);
            await _baturJwtContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _baturJwtContext.Set<T>().Update(entity);
            await _baturJwtContext.SaveChangesAsync();
        }
    }
}
