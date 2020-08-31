using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Controle.Biblioteca.API.IntegrationTest
{
    public class CategoriaIntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public CategoriaIntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Trait("Get", "Categoria")]
        [Theory(DisplayName = "Get")]
        [InlineData("/api/v1/categorias")]
        public async Task Get_Categoria_Returna_Sucesso(string url)
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
