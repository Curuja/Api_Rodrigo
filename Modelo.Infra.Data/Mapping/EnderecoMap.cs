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
                .HasColumnName("logradouro");

            builder.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnName("Bairro");

            builder.Property(c => c.Cidade)
                .IsRequired()

                .HasColumnName("Cidade");

            builder.Property(c => c.Estado)
              .IsRequired()

              .HasColumnName("Estado");
        }
    }
}