using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;

namespace Modelo.Infra.Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
        }

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.logradouro)
                .IsRequired()
                .HasColumnName("logradouro")
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnName("Bairro")
             .HasColumnType("varchar(40)");

            builder.Property(c => c.Cidade)
                .IsRequired()
                .HasColumnName("Cidade")
             .HasColumnType("varchar(40)");

            builder.Property(c => c.Estado)
              .IsRequired()
              .HasColumnName("Estado")
              .HasColumnType("varchar(40)");
        }
    }
}