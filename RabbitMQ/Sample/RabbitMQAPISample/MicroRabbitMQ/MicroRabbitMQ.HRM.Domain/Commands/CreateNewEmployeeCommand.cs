using MicroRabbitMQ.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Domain.Commands
{
    public class CreateNewEmployeeCommand : NewEmployeeCommand
    {
        public CreateNewEmployeeCommand(string firstName, string lastName, int age, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
    }
}
