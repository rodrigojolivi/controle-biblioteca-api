using Controle.Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Domain.Interfaces.Repositories
{
    public interface ILivroRepository : IUnitOfWork
    {
        Task<IEnumerable<Livro>> ListarTodosLivros();
        Task<Livro> ObterLivroPorId(Guid id);

        void Adicionar(Livro livro);
        void Atualizar(Livro livro);
        void Excluir(Livro livro);
    }
}
