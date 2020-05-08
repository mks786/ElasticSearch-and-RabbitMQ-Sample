using MicroRabbitMQ.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Domain.Commands
{
    public class NewEmployeeCommand : Command
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public int Age { get; protected set; }
        public int Salary { get; protected set; }
    }
}
