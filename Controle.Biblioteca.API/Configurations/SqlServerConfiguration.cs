using Controle.Biblioteca.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Biblioteca.API.Configurations
{
    public static class SqlServerConfiguration
    {
        public static IServiceCollection AddSqlServerConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BibliotecaContext> (options =>
                  options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));

            return services;
        }
    }
}
