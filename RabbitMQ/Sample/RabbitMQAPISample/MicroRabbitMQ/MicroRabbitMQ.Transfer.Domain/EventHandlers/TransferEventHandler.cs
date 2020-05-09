using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Transfer.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbitMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<NewEmployeeCreatedEvent>
    {
        public TransferEventHandler()
        {

        }
        public Task Handle(NewEmployeeCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
