using CqrsMediatorPattern.CQRS.Commands.Response;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Commands.Request;

public class DeleteBookCommandRequest: IRequest<DeleteBookCommandResponse>
{
    public int BookId { get; set; }
}
