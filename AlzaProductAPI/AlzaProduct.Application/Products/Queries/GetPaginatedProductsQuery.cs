using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Domain.Entities.Products;
using AutoMapper;
using MediatR;

namespace AlzaProduct.Application.Products.Queries;

public class GetPaginatedProductsQuery : IRequest<PaginatedList<ProductDto>>
{
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetPaginatedProductsQueryHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<GetPaginatedProductsQuery, PaginatedList<ProductDto>>
{
    public async Task<PaginatedList<ProductDto>> Handle(GetPaginatedProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetPaginatedProducts(request.PageIndex, request.PageSize);

        var totalCount = await productRepository.CountAsync();
        var totalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize);

        return new()
        {
            Items = mapper.Map<List<ProductDto>>(products),
            PageIndex = request.PageIndex,
            TotalPages = totalPages
        };
    }
}
