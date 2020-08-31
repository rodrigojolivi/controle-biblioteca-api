using System.Collections.Generic;

namespace Controle.Biblioteca.Domain.Entities
{
    public class Categoria : Entity
    {
        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public List<Livro> Livros { get; private set; }
    }
}
