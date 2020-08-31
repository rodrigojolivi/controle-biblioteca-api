using AutoMapper;
using Controle.Biblioteca.Application.Interfaces;
using Controle.Biblioteca.Application.ViewModels;
using Controle.Biblioteca.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Application.Services
{
    public class CategoriaApplication : ICategoriaApplication
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepository _livroRepository;

        public CategoriaApplication(
            IMapper mapper, 
            ICategoriaRepository livroRepository)
        {
            _mapper = mapper;
            _livroRepository = livroRepository;
        }

        public async Task<IEnumerable<CategoriaViewModel>> ListarTodasCategorias()
        {
            return _mapper.Map<IEnumerable<CategoriaViewModel>>(await _livroRepository.ListarTodasCategorias());
        }
    }
}
