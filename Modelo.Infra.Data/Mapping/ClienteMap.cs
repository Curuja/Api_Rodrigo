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

            builder.OwnsOne(c => c.CPF, cpf =>
            {
                cpf.Property(c => c.Numero)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasColumnType("varchar(11)");

                cpf.Property(c => c.DataEmissao)
                    .HasColumnName("CPFDataEmissao");
            });
     

            builder.Property(c => c.idade)
                .IsRequired()
                .HasColumnName("Idade");

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome")
             .HasColumnType("varchar(30)");
        }
    }
}