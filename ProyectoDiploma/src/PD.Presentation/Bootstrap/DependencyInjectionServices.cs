using Microsoft.Extensions.DependencyInjection;
using PD.Services;
using PD.Services.Interfaces;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionServices
    {
        public static void AddDependencyInjectionServices(this IServiceCollection services)
        {
            services
                .AddTransient<IFacturacionService, FacturacionService>();
        }
    }
}