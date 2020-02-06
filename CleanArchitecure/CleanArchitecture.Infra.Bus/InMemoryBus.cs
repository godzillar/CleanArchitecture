using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Bus
{
    public class InMemoryBus: IMediatorHandler
    {
        private readonly IMediator mediator;

        public InMemoryBus(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T: Command
        {
            return mediator.Send(command);
        }
    }
}
