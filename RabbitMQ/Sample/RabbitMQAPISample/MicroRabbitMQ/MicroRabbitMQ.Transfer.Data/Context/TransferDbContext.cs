using MicroRabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMQ.Transfer.Data.Context
{
    public class TransferDbContext: DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).UseIdentityColumn();
            });
        }
    }
}
