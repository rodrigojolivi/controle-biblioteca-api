using AutoMapper;
using Controle.Biblioteca.Application.Interfaces;
using Controle.Biblioteca.Application.ViewModels;
using Controle.Biblioteca.Domain.Entities;
using Controle.Biblioteca.Domain.Interfaces.Repositories;
using Controle.Biblioteca.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Application.Services
{
    public class LivroApplication : ILivroApplication
    {
        // Ao invés de retornar bool nos métodos Adicionar, Atualizar e Excluir
        // poderíamos tratar como uma validação, por exemplo:
        // Não existe o registro solicitado, este livro não pode ser excluído, pois ...

        private readonly IMapper _mapper;
        private readonly ILivroService _livroService;
        private readonly ILivroRepository _livroRepository;

        public LivroApplication(
            IMapper mapper, 
            ILivroService livroService, 
            ILivroRepository livroRepository)
        {
            _mapper = mapper;
            _livroService = livroService;
            _livroRepository = livroRepository;
        }

        public async Task<IEnumerable<LivroViewModel>> ListarTodosLivros()
        {
            return _mapper.Map<IEnumerable<LivroViewModel>>(await _livroRepository.ListarTodosLivros());
        }

        public async Task<LivroViewModel> ObterLivroPorId(Guid id)
        {
            return _mapper.Map<LivroViewModel>(await _livroRepository.ObterLivroPorId(id));
        }

        public async Task<bool> Adicionar(LivroViewModel livroViewModel)
        {
            await _livroService.Adicionar(_mapper.Map<Livro>(livroViewModel));

            return true;
        }

        public async Task<bool> Atualizar(LivroViewModel livroViewModel)
        {
            var livro = await _livroRepository.ObterLivroPorId(livroViewModel.Id);

            if (livro == null) return false;

            await _livroService.Atualizar(_mapper.Map(livroViewModel, livro));

            return true;
        }

        public async Task<bool> Excluir(Guid id)
        {
            var livro = await _livroRepository.ObterLivroPorId(id);

            if (livro == null) return false;

            await _livroService.Excluir(livro);

            return true;
        }
    }
}
