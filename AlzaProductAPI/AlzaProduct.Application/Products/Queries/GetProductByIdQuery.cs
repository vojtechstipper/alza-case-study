using AlzaProduct.Abstractions;
using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Domain.Entities.Products;
using AlzaProduct.Infrastructure.Exceptions;
using AutoMapper;
using MediatR;

namespace AlzaProduct.Application.Products.Queries;

public record GetProductByIdQuery(string Id) : IRequest<ProductDto>;

public class GetProductByIdQueryHandler(IRepository<Product> productRepository, IMapper mapper) : IRequestHandler<GetProductByIdQuery, ProductDto>
{
    public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.Id);
        Validate(product, request.Id);
        return mapper.Map<ProductDto>(product);
    }

    private void Validate(Product? product, string id)
    {
        if (product is null)
        {
            throw new NotFoundException($"Entity {typeof(Product)} with Id: {id} was not found");
        }
    }
}
