using Controle.Biblioteca.Domain.Entities;
using System;
using Xunit;

namespace Controle.Biblioteca.Domain.Test
{
    public class CategoriaTest
    {
        [Trait("Domínio", "Categoria")]
        [Fact(DisplayName = "Validar categoria")]
        public void Validar_Categoria_Retorna_Sucesso()
        {
            var categoria = new Categoria(
                nome: "Estudo",
                descricao: "Livro de estudo"); 

            Assert.NotNull(categoria);
            Assert.IsType<Categoria>(categoria);
            Assert.Contains("Estudo", categoria.Nome);
            Assert.StartsWith("Livro de estudo", categoria.Descricao);
            Assert.IsType<Guid>(categoria.Id);
            Assert.Null(categoria.Livros);
        }
    }
}
