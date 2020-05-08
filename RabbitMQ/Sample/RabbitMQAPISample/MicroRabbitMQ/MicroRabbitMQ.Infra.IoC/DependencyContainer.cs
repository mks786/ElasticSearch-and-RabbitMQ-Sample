using MediatR;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.HRM.Application.Interfaces;
using MicroRabbitMQ.HRM.Application.Services;
using MicroRabbitMQ.HRM.Data.Context;
using MicroRabbitMQ.HRM.Data.Repository;
using MicroRabbitMQ.HRM.Domain.CommandHandlers;
using MicroRabbitMQ.HRM.Domain.Commands;
using MicroRabbitMQ.HRM.Domain.Interfaces;
using MicroRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Employee Command
            services.AddTransient<IRequestHandler<CreateNewEmployeeCommand, bool>, NewEmployeeCommandHandler>();
            services.AddTransient<IRequestHandler<UpdateNewEmployeeCommand, bool>, UpdateEmployeeCommandHandler>();

            // Application Services
            services.AddTransient<IEmployeeService, EmployeeService>();

            //Data
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<HRMDBContext>();
        }
    }
}
