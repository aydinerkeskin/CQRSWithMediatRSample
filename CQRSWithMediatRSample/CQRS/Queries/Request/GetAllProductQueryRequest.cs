using CQRSWithMediatRSample.CQRS.Queries.Response;
using MediatR;
using System.Collections.Generic;

namespace CQRSWithMediatRSample.CQRS.Queries.Request
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {
    }
}
