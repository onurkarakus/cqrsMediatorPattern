namespace CqrsMediatorPattern.CQRS.Commands.Response;

public class CreateBookCommandResponse
{
    public bool IsSuccess { get; set; }
    public int CreatedBookId { get; set; }
}
