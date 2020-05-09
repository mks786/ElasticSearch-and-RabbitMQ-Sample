using MicroRabbitMQ.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMQ.Transfer.Domain.Interfaces
{
    public interface IEmployeeTransferRepository
    {
        IEnumerable<Employee> GetTransferEmployees();
        void TransferInsertEmployee(Employee employee);
        void TransferUpdateEmployee(int Id, Employee employee);
        void TransferDeleteEmployee(int id);
    }
}
