using MicroRabbitMQ.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Domain.Commands
{
    public class DeleteEmployeeCommand : DeleteCommand
    {
        public DeleteEmployeeCommand(int id)
        {
            Id = id;
        }
    }
}
