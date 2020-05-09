using MicroRabbitMQ.Transfer.Data.Context;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Models;
using System.Linq;

namespace MicroRabbitMQ.Transfer.Data.Repository
{
    public class EmployeeTransferRepository : IEmployeeTransferRepository
    {
        private readonly TransferDbContext _context;

        public EmployeeTransferRepository(TransferDbContext context)
        {
            _context = context;
        }
              

        public void TransferInsertEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public void TransferUpdateEmployee(int Id, Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }

        public bool TransferDeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(m => m.Id == id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return true;
        }
    }
}
