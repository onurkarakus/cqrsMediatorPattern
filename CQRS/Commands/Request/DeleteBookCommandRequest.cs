using CqrsMediatorPattern.CQRS.Commands.Response;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Commands.Request;

/// <summary>
/// Delete Book Command Request Model
/// </summary>
public class DeleteBookCommandRequest: IRequest<DeleteBookCommandResponse>
{
    /// <summary>Gets or sets the book identifier.</summary>
    /// <value>The book identifier.</value>
    public int BookId { get; set; }
}
