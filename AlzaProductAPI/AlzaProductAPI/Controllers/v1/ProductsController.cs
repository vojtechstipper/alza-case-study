using AlzaProduct.Application.Products.Commands;
using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Application.Products.Queries;
using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AlzaProductAPI.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProductsController(IMediator mediator) : ControllerBase
{
    [MapToApiVersion("1.0")]
    [HttpGet]
    [ProducesResponseType<List<ProductDto>>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult<List<ProductDto>>> GetProducts()
    {
        var products = await mediator.Send(new GetAllProductsQuery());

        if (products == null || products.Count == 0)
        {
            return NoContent();
        }

        return Ok(products);
    }

    [HttpGet("{id}")]
    [ProducesResponseType<ProductDto>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProductDto>> GetProductById([FromRoute] GetProductByIdQuery query)
    {
        return Ok(await mediator.Send(query));
    }

    [HttpPut("{id}/description")]
    [ProducesResponseType<ProductDto>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProductDto>> EditProductDescription([FromRoute] string id, [FromBody] EditProductDescriptionCommand command)
    {
        command.Id = id;
        return Ok(await mediator.Send(command));
    }
}
