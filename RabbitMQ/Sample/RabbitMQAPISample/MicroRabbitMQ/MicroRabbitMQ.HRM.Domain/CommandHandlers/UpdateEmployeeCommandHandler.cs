using MediatR;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.HRM.Domain.Commands;
using MicroRabbitMQ.HRM.Domain.Events;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbitMQ.HRM.Domain.CommandHandlers
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateNewEmployeeCommand, bool>
    {
        private readonly IEventBus _bus;

        public UpdateEmployeeCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(UpdateNewEmployeeCommand request, CancellationToken cancellationToken)
        {
            //Publish event to RabbitMQ
            _bus.Publish(new UpdateEmployeeCreatedEvent(request.Id, request.FirstName, request.LastName, request.Age, request.Salary));

            return Task.FromResult(true);
        }
    }
}
