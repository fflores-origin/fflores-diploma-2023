using PD.Core.DTOs;
using PD.Core.Interfaces;
using PD.Core.Mappers.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using PD.Services;
using PD.Services.Enums;

namespace PD.Core
{
    public class UsuarioManager : IUsuarioManager
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuariosMapper _usuariosMapper;

        public UsuarioManager(
            IUsuarioRepository usuarioRepository,
            IUsuariosMapper usuariosMapper)
        {
            _usuarioRepository = usuarioRepository;
            _usuariosMapper = usuariosMapper;
        }

        public void CrearUsuario(string username, string password)
        {
            _usuarioRepository.Create(username, Encryption.Encrypt(password));
        }

        public List<UsuarioDto> GetUsuarios()
        {
            var usuarios = _usuariosMapper.Map(_usuarioRepository.GetAll());
            return usuarios;
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