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
    public class TransferNewEmployeeEventHandler : IEventHandler<NewEmployeeCreatedEvent>
    {
        private readonly IEmployeeTransferRepository _enployeeTransferRepository;
        public TransferNewEmployeeEventHandler(IEmployeeTransferRepository enployeeTransferRepository)
        {
            _enployeeTransferRepository = enployeeTransferRepository;
        }
        public Task Handle(NewEmployeeCreatedEvent @event)
        {
            _enployeeTransferRepository.TransferInsertEmployee(new Employee()
            {
                FirstName = @event.FirstName,
                LastName = @event.LastName,
                Age = @event.Age,
                Salary = @event.Salary,
            });
            return Task.CompletedTask;
        }
    }
}
