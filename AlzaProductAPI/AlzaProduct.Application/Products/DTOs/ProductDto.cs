namespace AlzaProduct.Application.Products.DTOs;

public class ProductDto
{
    public required string Id { get; set; }
    public required string ImgUri { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
}
