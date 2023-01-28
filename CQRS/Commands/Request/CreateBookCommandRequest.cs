using CqrsMediatorPattern.CQRS.Commands.Response;
using CqrsMediatorPattern.Domain.Enums;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Commands.Request;

public class CreateBookCommandRequest: IRequest<CreateBookCommandResponse>
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public BookGenre? BookGenre { get; set; }
}
