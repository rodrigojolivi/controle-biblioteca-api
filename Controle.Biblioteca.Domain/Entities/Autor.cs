using System.Collections.Generic;

namespace Controle.Biblioteca.Domain.Entities
{
    public class Autor : Entity
    {
        public Autor(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public List<Livro> Livros { get; private set; }
    }
}
