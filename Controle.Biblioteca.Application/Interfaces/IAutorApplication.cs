using Controle.Biblioteca.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Application.Interfaces
{
    public interface IAutorApplication
    {
        Task<IEnumerable<AutorViewModel>> ListarTodosAutores();
    }
}
