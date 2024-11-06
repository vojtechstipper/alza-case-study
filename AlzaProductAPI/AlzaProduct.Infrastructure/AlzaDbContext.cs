using AlzaProduct.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace AlzaProduct.Infrastructure;

public class AlzaDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlzaDbContext).Assembly);
    }
}
