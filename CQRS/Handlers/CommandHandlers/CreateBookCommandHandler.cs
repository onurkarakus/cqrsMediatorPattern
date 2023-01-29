using CqrsMediatorPattern.CQRS.Commands.Request;
using CqrsMediatorPattern.CQRS.Commands.Response;
using CqrsMediatorPattern.Data.Context;
using CqrsMediatorPattern.Domain.Entities;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Handlers.CommandHandlers;

/// <summary>
/// Create Book Command Handler Model
/// </summary>
public class CreateBookCommandHandler: IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
{
    private readonly BookDbContext _dbContext;

    /// <summary>Initializes a new instance of the <see cref="CreateBookCommandHandler" /> class.</summary>
    /// <param name="dbContext">The database context.</param>
    public CreateBookCommandHandler(BookDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    /// <summary>Handles a request</summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Response from the request</returns>
    public Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
    {
        _ = _dbContext.Books.Add(new Book
        {
            BookGenre = request.BookGenre.Value,
            Created = DateTime.Now,
            Description = request.Description,
            Title = request.Title
        });

        var idInformation = _dbContext.SaveChanges();

        return Task.FromResult(new CreateBookCommandResponse { IsSuccess = true, CreatedBookId = idInformation });
    }
}
