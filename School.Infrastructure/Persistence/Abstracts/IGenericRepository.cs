using Microsoft.EntityFrameworkCore.Storage;

namespace School.Infrastructure.Persistence.Abstracts;
public interface IGenericRepository<T> where T : class
{

    Task<T?> GetByIdAsync(int id);
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
