using PD.Core.DTOs;
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

        List<Patente> GetPatentes();

        List<Patente> GetAllPatentes();

        List<Familia> GetAllFamilias();
    }
}