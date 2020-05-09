using MicroRabbitMQ.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.Transfer.Domain.Events
{
    public class NewEmployeeCreatedEvent : Event
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int Salary { get; private set; }

        public NewEmployeeCreatedEvent(string firstName, string lastName, int age, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
    }
}
