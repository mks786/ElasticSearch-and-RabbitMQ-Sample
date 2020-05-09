using MicroRabbitMQ.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Domain.Commands
{
    public class EmployeeCommand : Command
    {
        public int Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public int Age { get; protected set; }
        public int Salary { get; protected set; }
    }
}
