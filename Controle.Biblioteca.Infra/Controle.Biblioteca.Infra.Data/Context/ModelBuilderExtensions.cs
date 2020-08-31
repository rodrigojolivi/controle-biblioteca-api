using Controle.Biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Controle.Biblioteca.Infra.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Autor
            modelBuilder.Entity<Autor>().HasData(new Autor(nome: "Paulo Coelho"));
            modelBuilder.Entity<Autor>().HasData(new Autor(nome: "Eric Evans"));

            // Categoria
            modelBuilder.Entity<Categoria>().HasData(new Categoria(
                nome: "Ficção", 
                descricao: "Livros de ficção"));

            modelBuilder.Entity<Categoria>().HasData(new Categoria(
                nome: "Estudo", 
                descricao: "Livros para estudos"));
        }
    }
}
