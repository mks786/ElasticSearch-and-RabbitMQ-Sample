using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.HRM.Application.Interfaces;
using MicroRabbitMQ.HRM.Domain.Commands;
using MicroRabbitMQ.HRM.Domain.Interfaces;
using MicroRabbitMQ.HRM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEventBus _bus;

        public EmployeeService(IEmployeeRepository employeeRepository, IEventBus bus)
        {
            _employeeRepository = employeeRepository;
            _bus = bus;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

        public Employee GetEmployeeById(int Id)
        {
            return _employeeRepository.GetEmployeeById(Id);
        }

        public void InsertEmployee(Employee employee)
        {
            var createNewEmployee = new CreateNewEmployeeCommand(employee.FirstName,
                                                          employee.LastName,
                                                          employee.Age,
                                                          employee.Salary);
            _bus.SendCommand(createNewEmployee);
        }

        public void UpdateEmployee(int Id, Employee employee)
        {
            var createNewEmployee = new UpdateNewEmployeeCommand(employee.Id,
                                                                 employee.FirstName,
                                                                 employee.LastName,
                                                                 employee.Age,
                                                                 employee.Salary);
            _bus.SendCommand(createNewEmployee);
        }

        public bool DeleteEmployee(int Id)
        {
            return _employeeRepository.DeleteEmployee(Id);
        }
    }
}
