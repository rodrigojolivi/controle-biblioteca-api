using Controle.Biblioteca.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Application.Interfaces
{
    public interface ILivroApplication
    {
        Task<IEnumerable<LivroViewModel>> ListarTodosLivros();
        Task<LivroViewModel> ObterLivroPorId(Guid id);

        Task<bool> Adicionar(LivroViewModel livro);
        Task<bool> Atualizar(LivroViewModel livro);
        Task<bool> Excluir(Guid id);
    }
}
