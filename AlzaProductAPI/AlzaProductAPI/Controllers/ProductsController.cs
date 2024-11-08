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
    public async Task<ActionResult<List<ProductDto>>> GetProducts()
    {
        return await mediator.Send(new GetAllProductsQuery());
    }
}
