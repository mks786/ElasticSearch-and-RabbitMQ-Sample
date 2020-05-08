using MicroRabbitMQ.HRM.Application.Interfaces;
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

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

        public Employee GetEmployeeById(int Id)
        {
            return _employeeRepository.GetEmployeeById(Id);
        }

        public Employee InsertEmployee(Employee employee)
        {
            return _employeeRepository.InsertEmployee(employee);
        }

        public Employee UpdateEmployee(int Id, Employee employee)
        {
            return _employeeRepository.UpdateEmployee(Id, employee);
        }

        public bool DeleteEmployee(int Id)
        {
            return _employeeRepository.DeleteEmployee(Id);
        }
    }
}
