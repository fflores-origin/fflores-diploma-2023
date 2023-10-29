﻿using Microsoft.Extensions.DependencyInjection;
using PD.DataAccess;
using PD.DataAccess.Interfaces;
using PD.Repositories;
using PD.Repositories.Interfaces;

namespace PD.Presentation.Bootstrap
{
    internal static class DependencyInjectionRepositories
    {
        public static void AddDependencyInjectionRepositories(this IServiceCollection services)
        {
            services
                .AddTransient<IConnection, Connection>()
                .AddTransient<IUsuarioRepository, UsuarioRepository>()
                .AddTransient<IArticuloRepository, ArticuloRepository>()
                .AddTransient<ICategoriaRepository, CategoriaRepository>();
        }
    }
}