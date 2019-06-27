using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modelo.Domain.Entities;
using Modelo.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Context
{
    public class RodrigoContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                 optionsBuilder.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Projetos\\Meus projetos\\Web_api_Rodrigo\\webApiCore\\MSSQLLocalDB\\Rodrigo.mdf; Integrated Security = True; Connect Timeout = 30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Endereco>(new EnderecoMap().Configure);
        }
    }

 
}
