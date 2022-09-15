using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSWithMediatRSample.CQRS.Commands.Response
{
    public class DeleteProductCommandResponse
    {
        public bool IsSuccess { get; set; }
    }
}
