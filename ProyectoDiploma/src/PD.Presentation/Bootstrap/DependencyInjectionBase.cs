using Microsoft.Extensions.DependencyInjection;
using PD.Presentation.Forms.Articulos;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionBase
    {
        public static void AddDependendyInjectionBase(this IServiceCollection services)
        {
            services
                .AddSingleton<Main>()
                .AddSingleton<GestionArticulos>();
        }
    }
}