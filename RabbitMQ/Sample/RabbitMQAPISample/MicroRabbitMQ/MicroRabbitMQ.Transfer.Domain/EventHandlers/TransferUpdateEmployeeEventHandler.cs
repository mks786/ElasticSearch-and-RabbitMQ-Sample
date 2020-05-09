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
    public class TransferUpdateEmployeeEventHandler : IEventHandler<UpdateEmployeeEvent>
    {
        private readonly IEmployeeTransferRepository _enployeeTransferRepository;
        public TransferUpdateEmployeeEventHandler(IEmployeeTransferRepository enployeeTransferRepository)
        {
            _enployeeTransferRepository = enployeeTransferRepository;
        }
        public Task Handle(UpdateEmployeeEvent @event)
        {
            _enployeeTransferRepository.TransferUpdateEmployee(@event.Id, new Employee()
            {
                Id = @event.Id,
                FirstName = @event.FirstName,
                LastName = @event.LastName,
                Age = @event.Age,
                Salary = @event.Salary,
            });
            return Task.CompletedTask;
        }
    }
}
