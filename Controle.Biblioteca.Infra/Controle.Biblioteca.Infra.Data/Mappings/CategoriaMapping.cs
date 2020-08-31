using Controle.Biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Controle.Biblioteca.Infra.Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Nome).IsRequired();

            builder.Property(l => l.Descricao).IsRequired();
        }
    }
}
