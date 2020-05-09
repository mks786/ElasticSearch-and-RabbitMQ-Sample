using MicroRabbitMQ.Domain.Core.Events;

namespace MicroRabbitMQ.Transfer.Domain.Events
{
    public class DeleteEmployeeEvent : Event
    {
        public int Id { get; private set; }

        public DeleteEmployeeEvent(int id)
        {
            Id = id;
        }
    }
}
