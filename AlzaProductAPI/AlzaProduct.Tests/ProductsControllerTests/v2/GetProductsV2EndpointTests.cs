using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Application.Products.Queries;
using AlzaProduct.Application.Products.Queries.Validators;
using AlzaProduct.Domain.Entities.Products;
using AlzaProductAPI.Controllers.v2;
using FluentValidation.TestHelper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AlzaProduct.Tests.ProductsControllerTests.v2;

public class GetProductsV2EndpointTests
{
    private readonly Mock<IMediator> _mockMediator;
    private readonly ProductsController _controller;
    private readonly GetPaginatedProductsQueryValidator _validator;

    public GetProductsV2EndpointTests()
    {
        _mockMediator = new Mock<IMediator>();
        _controller = new ProductsController(_mockMediator.Object);
        _validator = new GetPaginatedProductsQueryValidator();
    }

    [Fact]
    public async Task GetAllProducts_ProductsExists_ReturnsOkResult()
    {
        var product = new Product { ImgUri = "", Name = "Test Product", Price = 10.0M };
        var productId = product.Id;

        _mockMediator
            .Setup(m => m.Send(It.IsAny<GetPaginatedProductsQuery>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new PaginatedList<ProductDto>()
            {
                Items = [
                    new() {
                        Id = productId,
                        ImgUri = product.ImgUri,
                        Name = product.Name,
                        Price = product.Price
                    }
                ]
            });

        var result = await _controller.GetProductsPaginated(new GetPaginatedProductsQuery());

        var okObjectResult = Assert.IsType<OkObjectResult>(result.Result);
        var paginatedList = Assert.IsType<PaginatedList<ProductDto>>(okObjectResult.Value);
        Assert.Equal(productId, paginatedList.Items.First().Id);
        Assert.Equal(200, okObjectResult.StatusCode);
    }

    [Fact]
    public void GetAllProducts_Negative_PageIndex()
    {
        var getProductsQuery = new GetPaginatedProductsQuery { PageIndex = -1 };

        var result = _validator.TestValidate(getProductsQuery);

        result.ShouldHaveValidationErrorFor(x => x.PageIndex);
    }

    [Fact]
    public Task GetAllProducts_Valid_PageIndex()
    {
        var getProductsQuery = new GetPaginatedProductsQuery { PageIndex = 1 };

        var result = _validator.TestValidate(getProductsQuery);

        Assert.True(result.IsValid);
        return Task.CompletedTask;
    }

    [Fact]
    public void GetAllProducts_Negative_PageSize()
    {
        var getProductsQuery = new GetPaginatedProductsQuery { PageSize = -1 };

        var result = _validator.TestValidate(getProductsQuery);

        result.ShouldHaveValidationErrorFor(x => x.PageSize);
    }

    [Fact]
    public Task GetAllProducts_Valid_PageSize()
    {
        var getProductsQuery = new GetPaginatedProductsQuery { PageSize = 10 };

        var result = _validator.TestValidate(getProductsQuery);

        Assert.True(result.IsValid);
        return Task.CompletedTask;
    }
}
