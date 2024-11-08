using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Application.Products.Queries;
using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AlzaProductAPI.Controllers.v2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProductsController(IMediator mediator) : ControllerBase
{
    [MapToApiVersion("2.0")]
    [HttpGet]
    [ProducesResponseType<PaginatedList<ProductDto>>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PaginatedList<ProductDto>>> GetProductsPaginated([FromQuery] GetPaginatedProductsQuery query)
    {
        var products = await mediator.Send(query);

        return Ok(products);
    }
}
