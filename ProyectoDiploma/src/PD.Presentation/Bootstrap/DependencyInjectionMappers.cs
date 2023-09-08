using Microsoft.Extensions.DependencyInjection;
using PD.Core.Mappers;
using PD.Core.Mappers.Interfaces;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionMappers
    {
        public static void AddDependencyInjectionMappers(this IServiceCollection services)
        {
            services
                .AddTransient<IArticulosMapper, ArticulosMapper>();
        }
    }
}