using Microsoft.Extensions.DependencyInjection;
using PD.Core;
using PD.Core.Interfaces;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionManagers
    {
        public static void AddDependencyInjectionManagers(this IServiceCollection services)
        {
            services
                .AddTransient<IUsuarioManager, UsuarioManager>()
                .AddTransient<IArticulosManager, ArticulosManager>();
        }
    }
}