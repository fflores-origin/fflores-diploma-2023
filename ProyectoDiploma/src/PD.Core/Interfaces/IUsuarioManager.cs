using PD.Core.DTOs;
using PD.Entities;
using PD.Services.Enums;

namespace PD.Core.Interfaces
{
    public interface IUsuarioManager
    {
        LoginResult Login(string username, string password);

        void LogOut();

        void CrearUsuario(string username, string password);

        List<UsuarioDto> GetUsuarios();

    }
}