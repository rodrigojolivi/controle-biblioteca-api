using Controle.Biblioteca.Application.Interfaces;
using Controle.Biblioteca.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Controle.Biblioteca.API.Controllers.v1
{
    [Route("api/v1/livros")]  
    public class LivroController : CustomController
    {
        // Não foram tratados os outros tipos de response, somente Ok e BadRequest
        
        private readonly ILivroApplication _livroApplication;   

        public LivroController(ILivroApplication livroApplication)
        {
            _livroApplication = livroApplication;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ListarTodosLivros()
        {
            return Response(await _livroApplication.ListarTodosLivros());
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObterLivroPorId(Guid id)
        {
            return Response(await _livroApplication.ObterLivroPorId(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Adicionar(LivroViewModel livroViewModel)
        {
            return Response(await _livroApplication.Adicionar(livroViewModel));
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Atualizar(LivroViewModel livroViewModel)
        {
            return Response(await _livroApplication.Atualizar(livroViewModel));
        }

        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Excluir(Guid id)
        {
            return Response(await _livroApplication.Excluir(id));
        }
    }
}
