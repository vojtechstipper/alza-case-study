using AlzaProduct.Application.Products.DTOs;
using AlzaProduct.Application.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AlzaProductAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController(IMediator mediator) : ControllerBase
{
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
}
