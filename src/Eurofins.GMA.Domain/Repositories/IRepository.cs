
using System.Linq.Expressions;

namespace Eurofins.GMA.Domain.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<IQueryable<TEntity>> List(Expression<Func<TEntity, bool>> expression);
    }
}
