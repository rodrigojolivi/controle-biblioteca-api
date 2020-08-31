using AutoMapper;
using Controle.Biblioteca.Application.ViewModels;
using Controle.Biblioteca.Domain.Entities;

namespace Controle.Biblioteca.Application.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<LivroViewModel, Livro>();
        }
    }
}
