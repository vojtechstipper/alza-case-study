using AlzaProduct.Abstractions;
using AlzaProduct.Application.Extensions;
using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Domain.Entities.Products;
using AutoMapper;
using MediatR;

namespace AlzaProduct.Application.Products.Queries;

public record GetProductByIdQuery(string Id) : IRequest<ProductDto>;

public class GetProductByIdQueryHandler(IRepository<Product> productRepository, IMapper mapper) : IRequestHandler<GetProductByIdQuery, ProductDto>
{
    public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.Id);

        product.Validate(request.Id);

        return mapper.Map<ProductDto>(product);
    }
}
