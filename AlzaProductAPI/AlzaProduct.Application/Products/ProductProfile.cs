using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Domain.Entities.Products;
using AutoMapper;

namespace AlzaProduct.Application.Products;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>();
    }
}
