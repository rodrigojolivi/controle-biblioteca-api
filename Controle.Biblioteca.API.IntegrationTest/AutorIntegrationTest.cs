using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Controle.Biblioteca.API.IntegrationTest
{
    public class AutorIntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public AutorIntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Trait("Get", "Autor")]
        [Theory(DisplayName = "Get")]
        [InlineData("/api/v1/autores")]
        public async Task Get_Autor_Returna_Sucesso(string url)
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
