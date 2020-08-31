using AutoMapper;
using Controle.Biblioteca.Application.ViewModels;
using Controle.Biblioteca.Domain.Entities;

namespace Controle.Biblioteca.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Autor, AutorViewModel>();

            CreateMap<Categoria, CategoriaViewModel>();

            CreateMap<Livro, LivroViewModel>()
                .ForMember(l => l.Autor, a => a.MapFrom(l => l.Autor))
                .ForMember(l => l.Categoria, c => c.MapFrom(l => l.Categoria));
        }       
    }
}
