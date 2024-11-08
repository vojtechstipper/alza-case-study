using AlzaProduct.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace AlzaProduct.Infrastructure;

public class DataSeeder
{
    private readonly ModelBuilder _modelBuilder;

    public DataSeeder(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        SeedProducts();
    }

    private void SeedProducts()
    {
        var random = new Random();
        var products = Enumerable.Range(1, 100).Select(i => new Product
        {
            Name = $"Product {i}",
            Description = $"Description {i}",
            ImgUri = "https://via.placeholder.com/150",
            Price = Math.Round((decimal)(random.NextDouble() * 900 + 100), 2)
        }).ToArray();

        _modelBuilder.Entity<Product>().HasData(products);
    }
}
