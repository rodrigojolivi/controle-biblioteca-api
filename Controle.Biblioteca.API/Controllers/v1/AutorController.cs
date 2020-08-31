using Controle.Biblioteca.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Controle.Biblioteca.API.Controllers.v1
{
    [Route("api/v1/autores")]  
    public class AutorController : CustomController
    {
        private readonly IAutorApplication _autorApplication;

        public AutorController(IAutorApplication autorApplication)
        {
            _autorApplication = autorApplication;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ListarTodosAutores()
        {
            return Response(await _autorApplication.ListarTodosAutores());
        }
    }
}
