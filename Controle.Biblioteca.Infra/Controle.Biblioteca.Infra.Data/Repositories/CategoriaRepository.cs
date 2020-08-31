using Controle.Biblioteca.Domain.Entities;
using Controle.Biblioteca.Domain.Interfaces.Repositories;
using Controle.Biblioteca.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controle.Biblioteca.Infra.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly BibliotecaContext _context;

        public CategoriaRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> ListarTodasCategorias()
        {
            return await _context.Categoria.AsNoTracking().ToListAsync();
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
