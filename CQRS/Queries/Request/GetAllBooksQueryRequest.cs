using CqrsMediatorPattern.CQRS.Queries.Response;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Queries.Request;

/// <summary>
/// Get All Books Query Request Model
/// </summary>
public class GetAllBooksQueryRequest:IRequest<List<GetAllBooksQueryResponse>>
{

}
