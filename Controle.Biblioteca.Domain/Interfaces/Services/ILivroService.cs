using Controle.Biblioteca.Domain.Entities;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Domain.Interfaces.Services
{
    public interface ILivroService
    {
        Task Adicionar(Livro livro);
        Task Atualizar(Livro livro);
        Task Excluir(Livro livro);
    }
}
