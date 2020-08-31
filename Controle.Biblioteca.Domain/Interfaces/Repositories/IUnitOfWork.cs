using System.Threading.Tasks;

namespace Controle.Biblioteca.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
