using AlzaProduct.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace AlzaProduct.Infrastructure.Repositories;

public class ProductRepository(AlzaDbContext context) : Repository<Product>(context), IProductRepository
{
    public async Task<int> CountAsync()
    {
        return await _context.Products.CountAsync();
    }

    public async Task<IEnumerable<Product>> GetPaginatedProducts(int pageIndex, int pageSize)
    {
        return await _context.Products
            .AsNoTracking()
            .OrderBy(x => x.Id)
            .Skip(pageSize * (pageIndex - 1))
            .Take(pageSize)
            .ToListAsync();
    }
}
