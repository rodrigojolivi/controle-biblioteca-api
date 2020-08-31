using Controle.Biblioteca.Domain.Entities;
using Controle.Biblioteca.Domain.Interfaces.Repositories;
using Controle.Biblioteca.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Controle.Biblioteca.Infra.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BibliotecaContext _context;

        public LivroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> ListarTodosLivros()
        {
            return await _context.Livro.AsNoTracking().Include(l => l.Autor).Include(l => l.Categoria).OrderBy(l => l.Titulo).ToListAsync();
        }

        public async Task<Livro> ObterLivroPorId(Guid id)
        {
            return await _context.Livro.FindAsync(id);
        }

        public void Adicionar(Livro livro)
        {
            _context.Livro.Add(livro);
        }

        public void Atualizar(Livro livro)
        {
            _context.Livro.Update(livro);
        }

        public void Excluir(Livro livro)
        {
            _context.Livro.Remove(livro);
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
