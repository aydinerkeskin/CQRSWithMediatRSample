using CQRSWithMediatRSample.CQRS.Commands.Request;
using CQRSWithMediatRSample.CQRS.Commands.Response;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSWithMediatRSample.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = Guid.NewGuid()
            };
        }
    }
}
