using Microsoft.Extensions.DependencyInjection;
using PD.Presentation.Forms.Articulos;
using PD.Presentation.Forms.Configuracion;
using PD.Presentation.Forms.Login;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionBase
    {
        public static void AddDependendyInjectionForms(this IServiceCollection services)
        {
            services
                .AddSingleton<Main>()
                .AddSingleton<Login>()
                .AddSingleton<Recover>();

            services.AddDependencyInjectionConfiguracion();
            services.AddDependencyInjectionArticulos();
        }

        private static void AddDependencyInjectionArticulos(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionListas>()
                .AddSingleton<EdicionArticulo>()
                .AddSingleton<GestionArticulos>();
        }

        private static void AddDependencyInjectionConfiguracion(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionarPermisos>()
                .AddSingleton<GestionarIdiomas>()
                .AddSingleton<GestionCategorias>();
        }
    }
}