using MicroRabbitMQ.HRM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int Id);
        Employee InsertEmployee(Employee employee);
        Employee UpdateEmployee(int Id, Employee employee);
        bool DeleteEmployee(int id);
    }
}
