using System;
using System.ComponentModel.DataAnnotations;

namespace Controle.Biblioteca.Application.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Descricao { get; set; }

        public bool Disponivel { get; set; }

        [Required]
        public Guid IdAutor { get; set; }

        [Required]
        public Guid IdCategoria { get;  set; }

        public CategoriaViewModel Categoria { get; set; }

        public AutorViewModel Autor { get; set; }
    }
}
