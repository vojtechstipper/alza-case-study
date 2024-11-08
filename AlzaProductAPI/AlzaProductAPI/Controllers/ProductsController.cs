using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AlzaProductAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController(IMediator mediator) : ControllerBase
{

}
