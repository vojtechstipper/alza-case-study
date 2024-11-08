using AlzaProduct.Abstractions;

namespace AlzaProduct.Domain.Entities.Products;

public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<Product>> GetPaginatedProducts(int pageIndex, int pageSize);
    Task<int> CountAsync();
}
