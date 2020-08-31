using Controle.Biblioteca.Domain.Entities;
using Controle.Biblioteca.Domain.Interfaces.Repositories;
using Controle.Biblioteca.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Domain.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task Adicionar(Livro livro)
        {
            _livroRepository.Adicionar(livro);
            await _livroRepository.Commit();
        }

        public async Task Atualizar(Livro livro)
        {
            _livroRepository.Atualizar(livro);
            await _livroRepository.Commit();
        }

        public async Task Excluir(Livro livro)
        {            
            _livroRepository.Excluir(livro);
            await _livroRepository.Commit();
        }
    }
}
