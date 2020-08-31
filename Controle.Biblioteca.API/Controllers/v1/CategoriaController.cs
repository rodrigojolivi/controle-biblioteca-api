using Controle.Biblioteca.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Controle.Biblioteca.API.Controllers.v1
{
    [Route("api/v1/categorias")]  
    public class CategoriaController : CustomController
    {
        private readonly ICategoriaApplication _categoriaApplication;

        public CategoriaController(ICategoriaApplication categoriaApplication)
        {
            _categoriaApplication = categoriaApplication;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ListarTodasCategorias()
        {
            return Response(await _categoriaApplication.ListarTodasCategorias());
        }
    }
}
