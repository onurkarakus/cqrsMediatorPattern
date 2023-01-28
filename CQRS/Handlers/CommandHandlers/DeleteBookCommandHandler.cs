using CqrsMediatorPattern.CQRS.Commands.Request;
using CqrsMediatorPattern.CQRS.Commands.Response;
using CqrsMediatorPattern.Data.Context;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Handlers.CommandHandlers;

public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
{
    private readonly BookDbContext _dbContext;

    public DeleteBookCommandHandler(BookDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

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
