using Controle.Biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Controle.Biblioteca.Infra.Data.Mappings
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Titulo).IsRequired();

            builder.Property(l => l.Descricao);

            builder.Property(l => l.Disponivel);

            builder.HasOne(l => l.Autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(l => l.IdAutor)
                .IsRequired();

            builder.HasOne(l => l.Categoria)
               .WithMany(a => a.Livros)
               .HasForeignKey(l => l.IdCategoria)
               .IsRequired();
        }
    }
}
