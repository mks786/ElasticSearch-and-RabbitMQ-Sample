using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Application.Interfaces
{
    public interface IEmployeeTransferService
    {
        void TransferInsertEmployee(Employee employee);
        void TransferUpdateEmployee(int Id, Employee employee);
        bool TransferDeleteEmployee(int id);
    }
}
