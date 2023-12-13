using Microsoft.Extensions.DependencyInjection;
using PD.Presentation.Forms.Articulos;
using PD.Presentation.Forms.Configuracion;
using PD.Presentation.Forms.Documentos;
using PD.Presentation.Forms.Login;
using PD.Presentation.Forms.Pedidos;
using PD.Presentation.Forms.Seguridad;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionBase
    {
        public static void AddDependendyInjectionForms(this IServiceCollection services)
        {
            services.AddDependencyInjectionBase();
            services.AddDependencyInjectionSeguridad();
            services.AddDependencyInjectionConfiguracion();
            services.AddDependencyInjectionClientes();
            services.AddDependencyInjectionArticulos();
        }

        private static void AddDependencyInjectionBase(this IServiceCollection services)
        {
            services
                .AddSingleton<Main>()
                .AddSingleton<Login>()
                .AddSingleton<Recover>();
        }

        private static void AddDependencyInjectionArticulos(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionListas>()
                .AddSingleton<GestionArticulos>()
                .AddSingleton<EdicionArticulo>()
                ;
        }

        private static void AddDependencyInjectionConfiguracion(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionarIdiomas>()
                .AddSingleton<GestionCategorias>();
        }

        private static void AddDependencyInjectionSeguridad(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionarUsuariosPermisos>()
                .AddSingleton<GestionarPatentes>()
                .AddSingleton<GestionarBitacora>();
        }

        private static void AddDependencyInjectionClientes(this IServiceCollection services)
        {
            services
                .AddSingleton<GestionarClientes>()
                .AddSingleton<GestionOrdenesCompra>()
                .AddSingleton<GestionarPedidos>();
        }
    }
}