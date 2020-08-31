using Microsoft.AspNetCore.Mvc;

namespace Controle.Biblioteca.API.Controllers.v1
{
    [ApiController]
    public class CustomController : ControllerBase
    {
        // Podemos tratar vários tipos de retorno aqui
        // Ex.: 201, 204, 401, 403, 412, 500, etc ...

        protected new IActionResult Response(bool result)
        {
            if (result) return Ok(new { message = "Sucesso" });            
            return BadRequest(new { message = "Ocorreu um erro na sua solicitação"});
        }

        protected new IActionResult Response(object data)
        {
            return Ok(new { data });
        }
    }
}
