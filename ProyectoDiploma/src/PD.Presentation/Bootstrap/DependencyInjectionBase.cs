using Microsoft.Extensions.DependencyInjection;
using PD.Presentation.Forms.Articulos;
using PD.Presentation.Forms.Configuracion;
using PD.Presentation.Forms.Login;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionBase
    {
        public static void AddDependendyInjectionBase(this IServiceCollection services)
        {
            services
                .AddSingleton<Main>()
                .AddSingleton<GestionArticulos>()
                .AddSingleton<Login>()
                .AddSingleton<Recover>()
                .AddSingleton<EdicionArticulo>()
                .AddSingleton<GestionarPermisos>();
        }
    }
}