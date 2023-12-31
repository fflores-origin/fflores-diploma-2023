﻿using PD.Core.DTOs;
using PD.Entities.Permisos;
using PD.Services.Enums;

namespace PD.Core.Interfaces
{
    public interface IUsuarioManager
    {
        LoginResult Login(string username, string password);

        void LogOut();

        void CrearUsuario(string username, string password);

        List<UsuarioDto> GetUsuarios();

        #region Permisos

        List<Patente> GetAllPatentes();

        List<Familia> GetAllFamilias();

        Array GetAllPermisos();

        List<PermisoBase> GetAllComponentes(Familia familia = null);

        PermisoBase SaveComponent(PermisoBase patente, bool esFamilia);

        bool PatenteExiste(PermisoBase permiso, PermisoBase patente);

        void CompleteComponent(Familia familia);

        void SaveFamilia(PermisoBase familiaSeleccionada);

        #endregion Permisos
    }
}