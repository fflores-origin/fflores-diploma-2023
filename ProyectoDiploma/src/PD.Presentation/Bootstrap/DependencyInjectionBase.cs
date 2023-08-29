using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PD.Presentation.Forms.Articulos;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionBase
    {
        public static void AddDependendyInjectionBase(this IServiceCollection services)
        {
            services.AddSingleton<Main>();
            services.AddSingleton<GestionArticulos>();
            services.AddLogging(configure => configure.AddConsole());
        }
    }
}