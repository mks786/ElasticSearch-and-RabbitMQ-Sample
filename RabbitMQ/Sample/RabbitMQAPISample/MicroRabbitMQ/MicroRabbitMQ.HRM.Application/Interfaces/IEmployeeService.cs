using MicroRabbitMQ.HRM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.HRM.Application.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int Id);
        void InsertEmployee(Employee employee);
        void UpdateEmployee(int Id, Employee employee);
        void DeleteEmployee(int id);
    }
}
