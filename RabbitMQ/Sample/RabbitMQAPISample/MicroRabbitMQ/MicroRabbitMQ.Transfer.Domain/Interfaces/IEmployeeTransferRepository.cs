using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Domain.Interfaces
{
    public interface IEmployeeTransferRepository
    {
        void TransferInsertEmployee(Employee employee);
        void TransferUpdateEmployee(int Id, Employee employee);
        bool TransferDeleteEmployee(int id);
    }
}
