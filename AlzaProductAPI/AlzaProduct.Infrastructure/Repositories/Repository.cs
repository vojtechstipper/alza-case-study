using AlzaProduct.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AlzaProduct.Infrastructure.Repositories;

public class Repository<T>(AlzaDbContext context) : IRepository<T> where T : Entity
{
    protected readonly AlzaDbContext _context = context;
    private readonly DbSet<T> _dbSet = context.Set<T>();

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(string id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }
}
