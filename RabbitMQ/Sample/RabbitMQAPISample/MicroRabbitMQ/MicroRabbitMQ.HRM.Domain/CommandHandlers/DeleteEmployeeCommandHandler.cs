using MediatR;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.HRM.Domain.Commands;
using MicroRabbitMQ.HRM.Domain.Events;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbitMQ.HRM.Domain.CommandHandlers
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IEventBus _bus;

        public DeleteEmployeeCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            //Publish event to RabbitMQ
            _bus.Publish(new DeleteEmployeeEvent(request.Id));

            return Task.FromResult(true);
        }
    }
}
