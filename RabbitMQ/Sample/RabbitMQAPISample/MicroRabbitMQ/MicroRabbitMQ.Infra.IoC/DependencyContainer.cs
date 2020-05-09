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
using MicroRabbitMQ.Transfer.Application.Interfaces;
using MicroRabbitMQ.Transfer.Application.Services;
using MicroRabbitMQ.Transfer.Data.Context;
using MicroRabbitMQ.Transfer.Data.Repository;
using MicroRabbitMQ.Transfer.Domain.EventHandlers;
using MicroRabbitMQ.Transfer.Domain.Events;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopFactory);
            });

            //Subscriptions
            services.AddTransient<TransferNewEmployeeEventHandler>();
            services.AddTransient<TransferUpdateEmployeeEventHandler>();
            services.AddTransient<TransferDeleteEmployeeEventHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<NewEmployeeCreatedEvent>, TransferNewEmployeeEventHandler>();
            services.AddTransient<IEventHandler<UpdateEmployeeEvent>, TransferUpdateEmployeeEventHandler>();
            services.AddTransient<IEventHandler<DeleteEmployeeEvent>, TransferDeleteEmployeeEventHandler>();

            //Domain Employee Command
            services.AddTransient<IRequestHandler<CreateNewEmployeeCommand, bool>, NewEmployeeCommandHandler>();
            services.AddTransient<IRequestHandler<UpdateEmployeeCommand, bool>, UpdateEmployeeCommandHandler>();
            services.AddTransient<IRequestHandler<DeleteEmployeeCommand, bool>, DeleteEmployeeCommandHandler>();

            // Application Services            
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IEmployeeTransferService, EmployeeTransferService>();

            //Data
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeTransferRepository, EmployeeTransferRepository>();

            services.AddTransient<HRMDBContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
