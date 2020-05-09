using MicroRabbitMQ.HRM.Data.Context;
using MicroRabbitMQ.HRM.Domain.Interfaces;
using MicroRabbitMQ.HRM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroRabbitMQ.HRM.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HRMDBContext _context;

        public EmployeeRepository(HRMDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            return _context.Employees.Find(Id);
        }
    }
}
