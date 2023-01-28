using CqrsMediatorPattern.CQRS.Queries.Response;
using MediatR;

namespace CqrsMediatorPattern.CQRS.Queries.Request;

public class GetAllBooksQueryRequest:IRequest<List<GetAllBooksQueryResponse>>
{

}
