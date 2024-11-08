using AlzaProduct.Abstractions;
using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Domain.Entities.Products;
using MediatR;

namespace AlzaProduct.Application.Products.Queries;

public record GetAllProductsQuery : IRequest<List<ProductDto>>;

public class GetAllProductsQueryHandler(IRepository<Product> productRepository) : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
{
    public async Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return (await productRepository.GetAllAsync()).Select(x => new ProductDto() { Id = x.Id, Name = x.Name, ImgUri = x.ImgUri }).ToList();
    }
}
