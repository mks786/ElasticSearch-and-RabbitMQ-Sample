using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Transfer.Domain.Events;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbitMQ.Transfer.Domain.EventHandlers
{
    public class TransferDeleteEmployeeEventHandler : IEventHandler<DeleteEmployeeEvent>
    {
        private readonly IEmployeeTransferRepository _enployeeTransferRepository;
        public TransferDeleteEmployeeEventHandler(IEmployeeTransferRepository enployeeTransferRepository)
        {
            _enployeeTransferRepository = enployeeTransferRepository;
        }
        public Task Handle(DeleteEmployeeEvent @event)
        {
            _enployeeTransferRepository.TransferDeleteEmployee(@event.Id);
            return Task.CompletedTask;
        }
    }
}
