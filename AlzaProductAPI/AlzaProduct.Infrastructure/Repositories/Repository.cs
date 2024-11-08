using AlzaProduct.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AlzaProduct.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : Entity
{
    private readonly AlzaDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AlzaDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
