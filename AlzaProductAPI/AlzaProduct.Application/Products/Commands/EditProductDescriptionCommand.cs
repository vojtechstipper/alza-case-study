using AlzaProduct.Abstractions;
using AlzaProduct.Application.Extensions;
using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Domain.Entities.Products;
using AutoMapper;
using MediatR;

namespace AlzaProduct.Application.Products.Commands;

public class EditProductDescriptionCommand : IRequest<ProductDto>
{
    public string Id { get; set; } = string.Empty;
    public string? Description { get; set; }
}

public class EditProductDescriptionCommandHandler(IRepository<Product> productRepository, IMapper mapper) : IRequestHandler<EditProductDescriptionCommand, ProductDto>
{
    public async Task<ProductDto> Handle(EditProductDescriptionCommand request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.Id);
        product.ValidateIfNotNull(request.Id);

        product!.Description = request.Description;
        productRepository.Update(product);
        await productRepository.SaveAsync();

        return mapper.Map<ProductDto>(product);
    }
}
