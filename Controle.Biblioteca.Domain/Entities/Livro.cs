using System;

namespace Controle.Biblioteca.Domain.Entities
{
    public class Livro : Entity
    {
        public Livro(string titulo, string descricao, bool disponivel, Guid idAutor, Guid idCategoria)
        {
            Titulo = titulo;
            Descricao = descricao;
            Disponivel = disponivel;
            IdAutor = idAutor;
            IdCategoria = idCategoria;
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public bool Disponivel { get; private set; }

        public Guid IdAutor { get; private set; }
        public Autor Autor { get; private set; }

        public Guid IdCategoria { get; private set; }
        public Categoria Categoria { get; private set; }
    }
}
