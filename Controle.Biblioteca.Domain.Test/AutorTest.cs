using Controle.Biblioteca.Domain.Entities;
using System;
using Xunit;

namespace Controle.Biblioteca.Domain.Test
{
    public class AutorTest
    {
        [Trait("Domínio", "Autor")]
        [Fact(DisplayName = "Validar autor")]
        public void Validar_Autor_Retorna_Sucesso()
        {
            var autor = new Autor(
                nome: "Eric Evans"); 

            Assert.NotNull(autor);
            Assert.IsType<Autor>(autor);
            Assert.Contains("Eric Evans", autor.Nome);
            Assert.IsType<Guid>(autor.Id);
            Assert.Null(autor.Livros);
        }
    }
}
