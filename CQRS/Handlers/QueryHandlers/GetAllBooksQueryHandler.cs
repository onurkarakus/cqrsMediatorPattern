using CqrsMediatorPattern.CQRS.Queries.Request;
using CqrsMediatorPattern.CQRS.Queries.Response;
using CqrsMediatorPattern.Data.Context;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Handlers.QueryHandlers;

public class GetAllBooksQueryHandler: IRequestHandler<GetAllBooksQueryRequest, List<GetAllBooksQueryResponse>>
{
    private readonly BookDbContext _dbContext;

    public GetAllBooksQueryHandler(BookDbContext dbContext)
    {
        this._dbContext = dbContext;
    }    

    public Task<List<GetAllBooksQueryResponse>> Handle(GetAllBooksQueryRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dbContext.Books.Select(x => new GetAllBooksQueryResponse()
        {
            BookGenre = x.BookGenre,
            Created = x.Created,
            Description = x.Description,
            Id = x.Id,
            Title = x.Title,
            Updated = x.Updated
        }).ToList());
    }
}
