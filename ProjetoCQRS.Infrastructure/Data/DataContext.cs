using Microsoft.EntityFrameworkCore;
using ProjetoCQRS.Domain.Entities;
using ProjetoCQRS.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCQRS.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {}

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");

            modelBuilder.ApplyConfiguration(new ClienteConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
