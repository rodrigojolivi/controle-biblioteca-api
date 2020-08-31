using Controle.Biblioteca.Domain.Entities;
using System;
using Xunit;

namespace Controle.Biblioteca.Domain.Test
{
    public class LivroTest
    {
        [Trait("Dom�nio", "Livro")]
        [Fact(DisplayName = "Validar livro dispon�vel")]
        public void Validar_Livro_Disponivel_Retorna_Sucesso()
        {
            var livro = new Livro(
                titulo: "Domain Driven Design", 
                descricao: "Este n�o � um livro sobre tecnologias espec�ficas. Ele oferece aos leitores uma abordagem " +
                "sistem�tica com rela��o ao domain-driven design, ou DDD, apresentando um conjunto abrangente de pr�ticas " +
                "ideais de design, t�cnicas baseadas em experi�ncias e princ�pios fundamentais que facilitam o desenvolvimento de " +
                "projetos de software que enfrentam dom�nios complexos", 
                disponivel: true, 
                idAutor: Guid.NewGuid(), 
                idCategoria: Guid.NewGuid());

            Assert.NotNull(livro);
            Assert.IsType<Livro>(livro);
            Assert.Contains("Domain Driven Design", livro.Titulo);
            Assert.StartsWith("Este n�o � um livro sobre tecnologias espec�ficas.", livro.Descricao);
            Assert.True(livro.Disponivel);
            Assert.IsType<Guid>(livro.Id);
            Assert.IsType<Guid>(livro.IdAutor);
            Assert.IsType<Guid>(livro.IdCategoria);
            Assert.Null(livro.Autor);
            Assert.Null(livro.Categoria);
        }
    }
}
