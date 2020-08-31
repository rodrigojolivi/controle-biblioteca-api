using Controle.Biblioteca.Domain.Entities;
using System;
using Xunit;

namespace Controle.Biblioteca.Domain.Test
{
    public class LivroTest
    {
        [Trait("Domínio", "Livro")]
        [Fact(DisplayName = "Validar livro disponível")]
        public void Validar_Livro_Disponivel_Retorna_Sucesso()
        {
            var livro = new Livro(
                titulo: "Domain Driven Design", 
                descricao: "Este não é um livro sobre tecnologias específicas. Ele oferece aos leitores uma abordagem " +
                "sistemática com relação ao domain-driven design, ou DDD, apresentando um conjunto abrangente de práticas " +
                "ideais de design, técnicas baseadas em experiências e princípios fundamentais que facilitam o desenvolvimento de " +
                "projetos de software que enfrentam domínios complexos", 
                disponivel: true, 
                idAutor: Guid.NewGuid(), 
                idCategoria: Guid.NewGuid());

            Assert.NotNull(livro);
            Assert.IsType<Livro>(livro);
            Assert.Contains("Domain Driven Design", livro.Titulo);
            Assert.StartsWith("Este não é um livro sobre tecnologias específicas.", livro.Descricao);
            Assert.True(livro.Disponivel);
            Assert.IsType<Guid>(livro.Id);
            Assert.IsType<Guid>(livro.IdAutor);
            Assert.IsType<Guid>(livro.IdCategoria);
            Assert.Null(livro.Autor);
            Assert.Null(livro.Categoria);
        }
    }
}
