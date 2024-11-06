using AlzaProduct.Abstractions;

namespace AlzaProduct.Domain.Entities.Products;

public class Product : Entity
{
    public required string Name { get; set; }
    public required string ImgUri { get; set; }
    public double Price { get; set; }
    public string? Description { get; set; }
}
