using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;

namespace Modelo.Infra.Data.Mapping
{
    internal class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
        }

        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnName("Cpf");

            builder.Property(c => c.idade)
                .IsRequired()
                .HasColumnName("Idade");

            builder.Property(c => c.Nome)
                .IsRequired()
      
                .HasColumnName("Nome");
        }
    }
}