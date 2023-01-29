using CqrsMediatorPattern.CQRS.Queries.Request;
using CqrsMediatorPattern.CQRS.Queries.Response;
using CqrsMediatorPattern.Data.Context;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Handlers.QueryHandlers;

/// <summary>
/// Get All Books Query Handler
/// </summary>
public class GetAllBooksQueryHandler: IRequestHandler<GetAllBooksQueryRequest, List<GetAllBooksQueryResponse>>
{
    private readonly BookDbContext _dbContext;

    /// <summary>Initializes a new instance of the <see cref="GetAllBooksQueryHandler" /> class.</summary>
    /// <param name="dbContext">The database context.</param>
    public GetAllBooksQueryHandler(BookDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    /// <summary>Handles a request</summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Response from the request</returns>
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
