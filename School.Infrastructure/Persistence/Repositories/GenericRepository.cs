using Microsoft.EntityFrameworkCore.Storage;
using School.Infrastructure.Persistence.Abstracts;

namespace School.Infrastructure.Persistence.Repositories;

internal class GenericRepository<T> : IGenericRepository<T> where T : class
{

    protected readonly ApplicationDbContext _dbContext;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<T> GetTableAsTracking()
    {
        return _dbContext.Set<T>().AsQueryable();
    }

    public async Task<T?> GetByIdAsync(int id)
    {

        return await _dbContext.Set<T>().FindAsync(id);
    }

    public IQueryable<T> GetTableNoTracking()
    {
        return _dbContext.Set<T>().AsNoTracking().AsQueryable();
    }

    public async Task AddRangeAsync(ICollection<T> entities)
    {
        await _dbContext.Set<T>().AddRangeAsync(entities);

    }
    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        return entity;
    }

    public void Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }
    public async Task UpdateRangeAsync(ICollection<T> entities)
    {
        _dbContext.Set<T>().UpdateRange(entities);
        await _dbContext.SaveChangesAsync();
    }


    public void Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }
    public async Task DeleteRangeAsync(ICollection<T> entities)
    {
        foreach (var entity in entities)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }
        await _dbContext.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }



    public IDbContextTransaction BeginTransaction()
    {
        return _dbContext.Database.BeginTransaction();
    }

    public void Commit()
    {
        _dbContext.Database.CommitTransaction();

    }

    public void RollBack()
    {
        _dbContext.Database.RollbackTransaction();

    }




}
