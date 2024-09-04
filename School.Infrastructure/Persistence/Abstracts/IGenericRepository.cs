using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace School.Infrastructure.Persistence.Abstracts;
public interface IGenericRepository<T> where T : class
{
    Task<T?> GetByIdAsync(int id);
    Task<T?> FindAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);

    IDbContextTransaction BeginTransaction();
    void Commit();
    void RollBack();
    IQueryable<T> GetTableNoTracking();
    IQueryable<T> GetTableAsTracking();

    Task<T> AddAsync(T entity);
    Task AddRangeAsync(ICollection<T> entities);

    void Update(T entity);
    Task UpdateRangeAsync(ICollection<T> entities);


    void Delete(T entity);
    Task DeleteRangeAsync(ICollection<T> entities);

    Task SaveChangesAsync();
}
