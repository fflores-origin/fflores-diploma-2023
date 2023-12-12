using Microsoft.Extensions.DependencyInjection;
using PD.Presentation.Forms.Articulos;
using PD.Presentation.Forms.Configuracion;
using PD.Presentation.Forms.Login;
using PD.Presentation.Forms.Pedidos;

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
            services.AddDependencyInjectionClientes();
        }

        private static void AddDependencyInjectionArticulos(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionListas>()
                .AddSingleton<GestionArticulos>()
                .AddSingleton<GestionarPedidos>()
                .AddSingleton<EdicionArticulo>()
                ;
        }

        private static void AddDependencyInjectionConfiguracion(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionarUsuariosPermisos>()
                .AddSingleton<GestionarIdiomas>()
                .AddSingleton<GestionCategorias>();
        }

        private static void AddDependencyInjectionClientes(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionarClientes>();
        }
    }
}