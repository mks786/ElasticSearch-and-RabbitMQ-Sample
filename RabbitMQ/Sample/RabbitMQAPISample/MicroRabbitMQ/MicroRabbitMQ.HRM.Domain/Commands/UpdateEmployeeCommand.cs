using MicroRabbitMQ.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Domain.Commands
{
    public class UpdateEmployeeCommand : EmployeeCommand
    {
        public UpdateEmployeeCommand(int id, string firstName, string lastName, int age, int salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
    }
}
