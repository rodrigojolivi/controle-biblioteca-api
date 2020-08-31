using Controle.Biblioteca.Domain.Entities;
using Controle.Biblioteca.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Controle.Biblioteca.Infra.Data.Context
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Livro> Livro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfiguration(new AutorMapping());
            modelBuilder.ApplyConfiguration(new CategoriaMapping());
            modelBuilder.ApplyConfiguration(new LivroMapping());

            ModelBuilderExtensions.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
