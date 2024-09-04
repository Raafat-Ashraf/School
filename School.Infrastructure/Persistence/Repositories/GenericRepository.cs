using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;
using School.Infrastructure.Persistence.Abstracts;
using System.Linq.Expressions;

namespace School.Infrastructure.Persistence.Repositories;

internal class GenericRepository<T> : IGenericRepository<T> where T : class
{

    private readonly ApplicationDbContext _context;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    public IQueryable<T> GetTableAsTracking()
    {
        return _context.Set<T>().AsQueryable();
    }

    public IQueryable<T> GetTableNoTracking()
    {
        return _context.Set<T>().AsNoTracking().AsQueryable();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }


    public async Task<T?> FindAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> query = _context.Set<T>().AsQueryable();

        if (include is not null)
            query = include(query);

        return await query.SingleOrDefaultAsync(predicate);
    }



    public async Task AddRangeAsync(ICollection<T> entities)
    {
        await _context.Set<T>().AddRangeAsync(entities);

    }
    public async Task<T> AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        return entity;
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
    public async Task UpdateRangeAsync(ICollection<T> entities)
    {
        _context.Set<T>().UpdateRange(entities);
        await _context.SaveChangesAsync();
    }


    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    public async Task DeleteRangeAsync(ICollection<T> entities)
    {
        foreach (var entity in entities)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }
        await _context.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }



    public IDbContextTransaction BeginTransaction()
    {
        return _context.Database.BeginTransaction();
    }

    public void Commit()
    {
        _context.Database.CommitTransaction();

    }

    public void RollBack()
    {
        _context.Database.RollbackTransaction();

    }

}
