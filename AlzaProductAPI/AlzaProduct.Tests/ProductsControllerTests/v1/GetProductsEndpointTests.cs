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

public class GetProductsEndpointTests
{
    private readonly Mock<IMediator> _mockMediator;
    private readonly Mock<IRepository<Product>> _productRepository;
    private readonly Mock<IMapper> _mapper;
    private readonly ProductsController _controller;

    public GetProductsEndpointTests()
    {

        _mockMediator = new Mock<IMediator>();
        _controller = new ProductsController(_mockMediator.Object);
        _productRepository = new Mock<IRepository<Product>>();
        _mapper = new Mock<IMapper>();

    }

    [Fact]
    public async Task GetAllProducts_ProductsExists_ReturnsOkResult()
    {
        // Arrange
        var product = new Product { ImgUri = "", Name = "Test Product", Price = 10.0M };
        var productId = product.Id;

        _mockMediator
            .Setup(m => m.Send(It.IsAny<GetAllProductsQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new List<ProductDto> { new ProductDto { Id = productId, ImgUri = product.ImgUri, Name = product.Name, Price = product.Price } });

        // Act
        var result = await _controller.GetProducts();

        // Assert
        var okResult = Assert.IsType<ActionResult<List<ProductDto>>>(result);
        var returnedProduct = Assert.IsType<OkObjectResult>(okResult.Result);
        var returnedProductProduct = Assert.IsType<List<ProductDto>>(returnedProduct.Value);
        Assert.Equal(productId, returnedProductProduct.First().Id);
        Assert.Equal(200, returnedProduct.StatusCode);
    }

    [Fact]
    public async Task GetAllProducts_ProductsExists_ReturnsNoContent()
    {
        // Arrange
        _mockMediator
            .Setup(m => m.Send(It.IsAny<GetAllProductsQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync([]);

        // Act
        var result = await _controller.GetProducts();

        // Assert
        var okResult = Assert.IsType<NoContentResult>(result.Result);
        Assert.Equal(204, okResult.StatusCode);
    }
}
