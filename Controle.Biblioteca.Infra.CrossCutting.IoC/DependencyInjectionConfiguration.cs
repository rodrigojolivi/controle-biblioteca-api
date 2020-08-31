using Controle.Biblioteca.Application.Interfaces;
using Controle.Biblioteca.Application.Services;
using Controle.Biblioteca.Domain.Interfaces.Repositories;
using Controle.Biblioteca.Domain.Interfaces.Services;
using Controle.Biblioteca.Domain.Services;
using Controle.Biblioteca.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Biblioteca.Infra.CrossCutting.IoC
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            // Application
            services.AddScoped<IAutorApplication, AutorApplication>();
            services.AddScoped<ICategoriaApplication, CategoriaApplication>();
            services.AddScoped<ILivroApplication, LivroApplication>();

            // Services
            services.AddScoped<ILivroService, LivroService>();

            // Repository
            services.AddScoped<IAutorRepository, AutorRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ILivroRepository, LivroRepository>();

            return services;
        }
    }
}
