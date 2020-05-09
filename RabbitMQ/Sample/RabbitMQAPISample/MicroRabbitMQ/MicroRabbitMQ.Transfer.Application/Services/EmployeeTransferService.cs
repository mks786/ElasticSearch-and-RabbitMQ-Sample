using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Transfer.Application.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMQ.Transfer.Application.Services
{
    public class EmployeeTransferService : IEmployeeTransferService
    {
        private readonly IEmployeeTransferRepository _employeeTransferRepository;

        public EmployeeTransferService(IEmployeeTransferRepository employeeTransferRepository)
        {
            _employeeTransferRepository = employeeTransferRepository;
        }

        public IEnumerable<Employee> GetTransferEmployees()
        {
            return _employeeTransferRepository.GetTransferEmployees();
        }
    }
}
