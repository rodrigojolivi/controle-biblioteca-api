using AutoMapper;
using Controle.Biblioteca.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Biblioteca.API.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToViewModel), typeof(ViewModelToDomain));

            return services;
        }
    }
}
