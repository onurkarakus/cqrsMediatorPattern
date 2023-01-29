using CqrsMediatorPattern.CQRS.Commands.Request;
using CqrsMediatorPattern.CQRS.Commands.Response;
using CqrsMediatorPattern.Data.Context;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Handlers.CommandHandlers;

/// <summary>
/// Delete Book Command Handler Model
/// </summary>
public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
{
    private readonly BookDbContext _dbContext;

    /// <summary>Initializes a new instance of the <see cref="DeleteBookCommandHandler" /> class.</summary>
    /// <param name="dbContext">The database context.</param>
    public DeleteBookCommandHandler(BookDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    /// <summary>Handles a request</summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Response from the request</returns>
    public Task<DeleteBookCommandResponse> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
    {
        var findBookResult = _dbContext.Books.FirstOrDefault(p => p.Id == request.BookId);

        if (findBookResult == null)
        {
            return Task.FromResult(new DeleteBookCommandResponse { IsSuccess = false });
        }

        _dbContext.Books.Remove(findBookResult);

        _ = _dbContext.SaveChanges();

        return Task.FromResult(new DeleteBookCommandResponse { IsSuccess = true });
    }
}
