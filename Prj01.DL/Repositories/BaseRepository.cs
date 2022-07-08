using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Prj01.DL.Abstract;
using Prj01.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseDbModel
    {
        protected readonly DbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly Expression<Func<T, bool>> entityContainsPharmacyId = x => true;

        public BaseRepository(DbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task AddAsync(IEntity entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>()
                                   .AnyAsync(predicate);
        }

        public async Task<bool> AnyAsync<T2>(Expression<Func<T2, bool>> predicate) where T2 : class, T
        {
            Expression<Func<T2, bool>> entityT2ContainsPharmacyId = x => true;
            return await _dbContext.Set<T2>()
                                   //.Where(x => !x.IsDeleted)
                                   .Where(entityT2ContainsPharmacyId)
                                   .AnyAsync(predicate);
        }

        public async Task<T> FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            var result = _dbContext.Set<T>()
                                   .FirstOrDefault(predicate);
            return result;
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> GetAllEntitiesAsync()
        {
            var result = _dbContext.Set<T>();
            return result;
        }

        public IQueryable<T> GetEntitiesWhereAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
