using PD.Services.Enums;

namespace PD.Core.Interfaces
{
    public interface IUsuarioManager
    {
        LoginResult Login(string username, string password);
        void LogOut();
    }
}