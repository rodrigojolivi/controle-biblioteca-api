using Controle.Biblioteca.Application.ViewModels;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Controle.Biblioteca.API.IntegrationTest
{
    // Os testes de Post, Put e Delete foram implementados apenas conceitualmente
    // Não foi incluído banco em memória 

    public class LivroIntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public LivroIntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Trait("Get", "Livro")]
        [Theory(DisplayName = "Get")]
        [InlineData("/api/v1/livros")]
        [InlineData("/api/v1/livros/0c884df6-3822-4d6b-bb2d-b7f16f1a77dd")]
        public async Task Get_Livro_Returna_Sucesso(string url)
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Trait("Post", "Livro")]
        [Theory(DisplayName = "Post")]
        [InlineData("/api/v1/livros")]
        public async Task Post_Livro_Returna_Erro(string url)
        {
            var client = _factory.CreateClient();

            var livro = new LivroViewModel
            {
                Titulo = "Domain Driven Design",
                Descricao = "Conceitos de DDD",
                Disponivel = true,
                IdAutor = new Guid("b8ba479c-7c95-4b13-956f-984e498c1a30"),
                IdCategoria = new Guid("7e0fabda-bfac-4ea2-9951-718cb5d6c61e"),
            };

            var content = new StringContent(JsonConvert.SerializeObject(livro), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Trait("Put", "Livro")]
        [Theory(DisplayName = "Put")]
        [InlineData("/api/v1/livros")]
        public async Task Put_Livro_Returna_Erro(string url)
        {
            var client = _factory.CreateClient();

            var livro = new LivroViewModel
            {
                Id = new Guid("0f881248-7032-4564-97aa-089986fe040c"),
                Titulo = "Domain Driven Design",
                Descricao = "Conceitos de DDD",
                Disponivel = true,
                IdAutor = new Guid("b8ba479c-7c95-4b13-956f-984e498c1a30"),
                IdCategoria = new Guid("7e0fabda-bfac-4ea2-9951-718cb5d6c61e"),
            };

            var content = new StringContent(JsonConvert.SerializeObject(livro), Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, content);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Trait("Delete", "Livro")]
        [Theory(DisplayName = "Delete")]
        [InlineData("/api/v1/livros/0e9ee304-605a-4097-90b2-84d4849b46f3")]
        public async Task Delete_Livro_Returna_Erro(string url)
        {
            var client = _factory.CreateClient();

            var response = await client.DeleteAsync(url);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
