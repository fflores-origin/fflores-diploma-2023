using Microsoft.Extensions.DependencyInjection;
using PD.Repositories;
using PD.Repositories.Interfaces;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionRepositories
    {
        public static void AddDependencyInjectionRepositories(this IServiceCollection services)
        {
            services.AddTransient<IArticuloRepository, ArticuloRepository>();
        }
    }
}