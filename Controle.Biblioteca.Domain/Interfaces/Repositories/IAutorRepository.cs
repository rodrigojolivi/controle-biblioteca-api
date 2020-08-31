using Controle.Biblioteca.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Domain.Interfaces.Repositories
{
    public interface IAutorRepository : IUnitOfWork
    {
        Task<IEnumerable<Autor>> ListarTodosAutores();
    }
}
