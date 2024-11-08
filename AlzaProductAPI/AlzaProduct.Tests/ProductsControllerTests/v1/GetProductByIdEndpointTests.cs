using AlzaProduct.Abstractions;
using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Application.Products.Queries;
using AlzaProduct.Domain.Entities.Products;
using AlzaProduct.Infrastructure.Exceptions;
using AlzaProductAPI.Controllers.v1;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AlzaProduct.Tests.ProductsControllerTests.v1;

public class GetProductByIdEndpointTests
{
    private readonly Mock<IMediator> _mockMediator;
    private readonly Mock<IRepository<Product>> _productRepository;
    private readonly Mock<IMapper> _mapper;
    private readonly ProductsController _controller;

    public GetProductByIdEndpointTests()
    {

        _mockMediator = new Mock<IMediator>();
        _controller = new ProductsController(_mockMediator.Object);
        _productRepository = new Mock<IRepository<Product>>();
        _mapper = new Mock<IMapper>();
    }

    [Fact]
    public async Task GetProductById_ProductExists_ReturnsOkResult()
    {
        var product = new Product { ImgUri = "", Name = "Test Product", Price = 10.0M };
        var productId = product.Id;
        _mockMediator
            .Setup(m => m.Send(It.Is<GetProductByIdQuery>(q => q.Id == productId), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ProductDto { Id = productId, ImgUri = product.ImgUri, Name = product.Name, Price = product.Price });

        var result = await _controller.GetProductById(new GetProductByIdQuery(productId));

        var returnedProduct = Assert.IsType<OkObjectResult>(result.Result);
        var returnedProductProduct = Assert.IsType<ProductDto>(returnedProduct.Value);
        Assert.Equal(productId, returnedProductProduct.Id);
        Assert.Equal(200, returnedProduct.StatusCode);
    }

    [Fact]
    public async Task GetProductById_ProductDoesNotExist_ReturnsNotFound()
    {
        var nonExistingId = "1";
        _productRepository.Setup(p => p.GetByIdAsync(nonExistingId)).ReturnsAsync((Product?)null);

        var handler = new GetProductByIdQueryHandler(_productRepository.Object, _mapper.Object);

        await Assert.ThrowsAsync<NotFoundException>(() => handler.Handle(new GetProductByIdQuery(nonExistingId), default));
    }
}
