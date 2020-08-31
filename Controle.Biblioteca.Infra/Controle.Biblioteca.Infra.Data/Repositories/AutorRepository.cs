using Controle.Biblioteca.Domain.Entities;
using Controle.Biblioteca.Domain.Interfaces.Repositories;
using Controle.Biblioteca.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Infra.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly BibliotecaContext _context;

        public AutorRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Autor>> ListarTodosAutores()
        {
            return await _context.Autor.AsNoTracking().ToListAsync();
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
