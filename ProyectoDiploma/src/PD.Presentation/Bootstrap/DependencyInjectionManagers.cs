using Microsoft.Extensions.DependencyInjection;
using PD.Core;
using PD.Core.Interfaces;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionManagers
    {
        public static void AddDependencyInjectionmanagers(this IServiceCollection services)
        {
            services.AddTransient<IArticulosManager, ArticulosManager>();
        }
    }
}