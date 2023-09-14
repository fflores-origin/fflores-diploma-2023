using PD.Core.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using PD.Services;
using PD.Services.Enums;

namespace PD.Core
{
    public class UsuarioManager : IUsuarioManager
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioManager(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void CrearUsuario(string username, string password)
        {
            _usuarioRepository.Create(username, Encryption.Encrypt(password));
        }

        public LoginResult Login(string username, string password)
        {
            Usuario usuario = _usuarioRepository.GetByUserame(username);

            if (usuario == null) { return LoginResult.InvalidUsername; }

            return LoginResult.InvalidUsername;
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }
    }
}