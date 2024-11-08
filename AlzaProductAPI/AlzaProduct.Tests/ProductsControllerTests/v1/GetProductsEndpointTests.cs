using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Application.Products.Queries;
using AlzaProduct.Domain.Entities.Products;
using AlzaProductAPI.Controllers.v1;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AlzaProduct.Tests.ProductsControllerTests.v1;

public class GetProductsEndpointTests
{
    private readonly Mock<IMediator> _mockMediator;
    private readonly ProductsController _controller;

    public GetProductsEndpointTests()
    {
        _mockMediator = new Mock<IMediator>();
        _controller = new ProductsController(_mockMediator.Object);
    }

    [Fact]
    public async Task GetAllProducts_ProductsExists_ReturnsOkResult()
    {
        var product = new Product { ImgUri = "", Name = "Test Product", Price = 10.0M };
        var productId = product.Id;

        _mockMediator
            .Setup(m => m.Send(It.IsAny<GetAllProductsQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync([new() { Id = productId, ImgUri = product.ImgUri, Name = product.Name, Price = product.Price }]);

        var result = await _controller.GetProducts();

        var okResult = Assert.IsType<ActionResult<List<ProductDto>>>(result);
        var returnedProduct = Assert.IsType<OkObjectResult>(okResult.Result);
        var returnedProductProduct = Assert.IsType<List<ProductDto>>(returnedProduct.Value);
        Assert.Equal(productId, returnedProductProduct[0].Id);
        Assert.Equal(200, returnedProduct.StatusCode);
    }

    [Fact]
    public async Task GetAllProducts_ProductsExists_ReturnsNoContent()
    {
        _mockMediator
            .Setup(m => m.Send(It.IsAny<GetAllProductsQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync([]);

        var result = await _controller.GetProducts();

        var okResult = Assert.IsType<NoContentResult>(result.Result);
        Assert.Equal(204, okResult.StatusCode);
    }
}
