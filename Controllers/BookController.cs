using CqrsMediatorPattern.CQRS.Commands.Request;
using CqrsMediatorPattern.CQRS.Commands.Response;
using CqrsMediatorPattern.CQRS.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatorPattern.Controllers;

/// <summary>
/// Book Controller Model
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    readonly IMediator mediator;

    /// <summary>Initializes a new instance of the <see cref="BookController" /> class.</summary>
    /// <param name="mediator">The mediator.</param>
    public BookController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>Gets the specified request.</summary>
    /// <param name="request">The request.</param>
    /// <returns><br /></returns>
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetAllBooksQueryRequest request)
    {
        var allBooks = await mediator.Send(request);

        return Ok(allBooks);
    }

    /// <summary>Posts the specified request.</summary>
    /// <param name="request">The request.</param>
    /// <returns><br /></returns>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateBookCommandRequest request)
    {
        CreateBookCommandResponse response = await mediator.Send(request);

        return Ok(response);
    }

    /// <summary>Deletes the specified request.</summary>
    /// <param name="request">The request.</param>
    /// <returns><br /></returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromQuery] DeleteBookCommandRequest request)
    {
        DeleteBookCommandResponse response = await mediator.Send(request);

        return Ok(response);
    }
}
