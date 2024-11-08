using AlzaProduct.Abstractions;
using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Domain.Entities.Products;
using AutoMapper;
using MediatR;

namespace AlzaProduct.Application.Products.Queries;

public record GetAllProductsQuery : IRequest<List<ProductDto>>;

public class GetAllProductsQueryHandler(IRepository<Product> productRepository, IMapper mapper) : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
{
    public async Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetAllAsync();
        return mapper.Map<List<ProductDto>>(products);
    }
}
