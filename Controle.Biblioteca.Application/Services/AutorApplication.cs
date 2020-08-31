using AutoMapper;
using Controle.Biblioteca.Application.Interfaces;
using Controle.Biblioteca.Application.ViewModels;
using Controle.Biblioteca.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Application.Services
{
    public class AutorApplication : IAutorApplication
    {
        private readonly IMapper _mapper;
        private readonly IAutorRepository _livroRepository;

        public AutorApplication(
            IMapper mapper, 
            IAutorRepository livroRepository)
        {
            _mapper = mapper;
            _livroRepository = livroRepository;
        }

        public async Task<IEnumerable<AutorViewModel>> ListarTodosAutores()
        {
            return _mapper.Map<IEnumerable<AutorViewModel>>(await _livroRepository.ListarTodosAutores());
        }
    }
}
