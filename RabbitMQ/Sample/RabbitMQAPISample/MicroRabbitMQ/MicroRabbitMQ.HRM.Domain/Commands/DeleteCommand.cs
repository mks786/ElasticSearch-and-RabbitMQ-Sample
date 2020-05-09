using MicroRabbitMQ.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Domain.Commands
{
    public class DeleteCommand : Command
    {
        public int Id { get; protected set; }
    }
}
