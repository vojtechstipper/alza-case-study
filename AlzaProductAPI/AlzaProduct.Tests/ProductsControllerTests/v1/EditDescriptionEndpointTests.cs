using AlzaProduct.Abstractions;
using AlzaProduct.Application.Products.Commands;
using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Domain.Entities.Products;
using AlzaProduct.Infrastructure.Exceptions;
using AlzaProductAPI.Controllers.v1;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AlzaProduct.Tests.ProductsControllerTests.v1;

public class EditDescriptionEndpointTests
{
    private readonly Mock<IMediator> _mockMediator;
    private readonly Mock<IMapper> _mapper;
    private readonly ProductsController _controller;

    public EditDescriptionEndpointTests()
    {

        _mockMediator = new Mock<IMediator>();
        _controller = new ProductsController(_mockMediator.Object);
        _mapper = new Mock<IMapper>();
    }

    [Fact]
    public async Task EditDescription_ProductExists_ReturnsOkResult()
    {
        // Arrange
        var product = new Product { ImgUri = "", Name = "Test Product", Price = 10.0M, Description = "Popisek" };
        var productId = product.Id;
        _mockMediator
            .Setup(m => m.Send(It.Is<EditProductDescriptionCommand>(q => q.Id == productId), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ProductDto { Id = productId, ImgUri = product.ImgUri, Name = product.Name, Price = product.Price, Description = "Popisek editovaný" });

        // Act
        var result = await _controller.EditProductDescription(productId, new EditProductDescriptionCommand());

        // Assert
        var okObjectResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnedProduct = Assert.IsType<ProductDto>(okObjectResult.Value);
        Assert.NotEqual(product.Description, returnedProduct.Description);
        Assert.Equal(200, okObjectResult.StatusCode);
    }

    [Fact]
    public async Task EditDescription_ProductDoesNotExist_ThrowsNotFound_Exception()
    {
        // Arrange
        var nonExistingId = "1";

        _mockMediator.Setup(m => m.Send(It.IsAny<EditProductDescriptionCommand>(), It.IsAny<CancellationToken>()))
                 .ThrowsAsync(new NotFoundException("Product not found"));

        // Act & Assert
        await Assert.ThrowsAsync<NotFoundException>(() => _controller.EditProductDescription(nonExistingId, new EditProductDescriptionCommand()));
    }
}
