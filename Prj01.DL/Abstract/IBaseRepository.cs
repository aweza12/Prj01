using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL.Abstract
{
    public interface IBaseRepository<T>
    {
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(IEntity entity);
        Task<bool> AnyAsync<T2>(Expression<Func<T2, bool>> predicate) where T2 : class, T;
        IQueryable<T> GetEntitiesWhereAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAllEntitiesAsync();
        Task<T> FindAsync(Guid id);
        Task UpdateAsync(T entity);
    }
}
