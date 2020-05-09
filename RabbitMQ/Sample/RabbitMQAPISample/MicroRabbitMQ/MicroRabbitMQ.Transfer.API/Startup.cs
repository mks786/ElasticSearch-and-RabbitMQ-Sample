using System.Reflection;
using MediatR;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Infra.IoC;
using MicroRabbitMQ.Transfer.Data.Context;
using MicroRabbitMQ.Transfer.Domain.EventHandlers;
using MicroRabbitMQ.Transfer.Domain.Events;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace MicroRabbitMQ.Transfer.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
            var connectionString = Configuration.GetConnectionString("TransferDbConnection");
            services.AddDbContext<TransferDbContext>(options =>
            {
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("MicroRabbitMQ.Transfer.Data"));
            });

            //services.AddControllers();
            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Transfer", Version = "v1" });
            });

            services.AddMediatR(typeof(Startup));

            RegisterServices(services);
        }

        private void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Transfer Microservice V1");
            });

            ConfigureEventBus(app);
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void ConfigureEventBus(IApplicationBuilder app)
        {
            var eventBus = app.ApplicationServices.GetRequiredService<IEventBus>();
            eventBus.Subscriber<NewEmployeeCreatedEvent, TransferNewEmployeeEventHandler>();
            eventBus.Subscriber<UpdateEmployeeEvent, TransferUpdateEmployeeEventHandler>();
            eventBus.Subscriber<DeleteEmployeeEvent, TransferDeleteEmployeeEventHandler>();
        }
    }
}
