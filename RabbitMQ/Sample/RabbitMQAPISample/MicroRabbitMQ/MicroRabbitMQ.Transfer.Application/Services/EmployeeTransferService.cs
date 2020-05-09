using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Transfer.Application.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Application.Services
{
    public class EmployeeTransferService : IEmployeeTransferService
    {
        private readonly IEmployeeTransferRepository _employeeTransferRepository;
        private readonly IEventBus _bus;

        public EmployeeTransferService(IEmployeeTransferRepository employeeTransferRepository, IEventBus bus)
        {
            _employeeTransferRepository = employeeTransferRepository;
            _bus = bus;
        }

        public void TransferInsertEmployee(Employee employee)
        {
            //var transferCreateNewEmployee = new TransferCreateNewEmployeeCommand(employee.FirstName,
            //                                              employee.LastName,
            //                                              employee.Age,
            //                                              employee.Salary);
            //_bus.SendCommand(transferCreateNewEmployee);
        }

        public void TransferUpdateEmployee(int Id, Employee employee)
        {
            //var transferCreateNewEmployee = new TransferUpdateNewEmployeeCommand(employee.Id,
            //                                                     employee.FirstName,
            //                                                     employee.LastName,
            //                                                     employee.Age,
            //                                                     employee.Salary);
            //_bus.SendCommand(transferCreateNewEmployee);
        }

        public bool TransferDeleteEmployee(int Id)
        {
            return _employeeTransferRepository.TransferDeleteEmployee(Id);
        }
    }
}
