using CqrsMediatorPattern.CQRS.Commands.Request;
using CqrsMediatorPattern.CQRS.Commands.Response;
using CqrsMediatorPattern.CQRS.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatorPattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    readonly IMediator mediator;

    public BookController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetAllBooksQueryRequest request)
    {
        var allBooks = await mediator.Send(request);

        return Ok(allBooks);
    }        

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateBookCommandRequest request)
    {
        CreateBookCommandResponse response = await mediator.Send(request);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromQuery] DeleteBookCommandRequest request)
    {
        DeleteBookCommandResponse response = await mediator.Send(request);

        return Ok(response);
    }
}
