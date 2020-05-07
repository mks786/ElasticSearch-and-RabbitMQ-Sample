using MicroRabbitMQ.Domain.Core.Commands;
using MicroRabbitMQ.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscriber<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}