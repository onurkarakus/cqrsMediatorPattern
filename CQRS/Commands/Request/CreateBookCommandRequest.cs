using CqrsMediatorPattern.CQRS.Commands.Response;
using CqrsMediatorPattern.Domain.Enums;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Commands.Request;

/// <summary>
/// Create Book Command Request Model
/// </summary>
public class CreateBookCommandRequest: IRequest<CreateBookCommandResponse>
{
    /// <summary>Gets or sets the title.</summary>
    /// <value>The title.</value>
    public string? Title { get; set; }

    /// <summary>Gets or sets the description.</summary>
    /// <value>The description.</value>
    public string? Description { get; set; }

    /// <summary>Gets or sets the book genre.</summary>
    /// <value>The book genre.</value>
    public BookGenre? BookGenre { get; set; }
}
