using CqrsMediatorPattern.CQRS.Commands.Request;
using CqrsMediatorPattern.CQRS.Commands.Response;
using CqrsMediatorPattern.Data.Context;
using CqrsMediatorPattern.Domain.Entities;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Handlers.CommandHandlers;

public class CreateBookCommandHandler: IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
{
    private readonly BookDbContext _dbContext;

    public CreateBookCommandHandler(BookDbContext dbContext)
    {
        this._dbContext = dbContext;
    }    

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
