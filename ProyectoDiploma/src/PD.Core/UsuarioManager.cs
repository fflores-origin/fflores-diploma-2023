using PD.Core.DTOs;
using PD.Core.Interfaces;
using PD.Core.Mappers.Interfaces;
using PD.Entities;
using PD.Entities.Permisos;
using PD.Repositories.Interfaces;
using PD.Services;
using PD.Services.Enums;

namespace PD.Core
{
    public class UsuarioManager : IUsuarioManager
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly IUsuariosMapper _usuariosMapper;
        private readonly Sesion _sesion;

        public UsuarioManager(
            IUsuarioRepository usuarioRepository,
            IUsuariosMapper usuariosMapper,
            ILanguageRepository languageRepository)
        {
            _usuarioRepository = usuarioRepository;
            _usuariosMapper = usuariosMapper;
            _sesion = UserSesion.Session;
            _languageRepository = languageRepository;
        }

        public void CrearUsuario(string username, string password)
        {
            _usuarioRepository.Create(username, Encryption.Encrypt(password));
        }

        public List<Patente> GetPatentes()
        {
            List<Patente> pantentes = _usuarioRepository.GetAllPantente();
            return pantentes;
        }

        public List<UsuarioDto> GetUsuarios()
        {
            var usuarios = _usuarioRepository.GetAll();
            var usuariosDto = _usuariosMapper.Map(usuarios);
            return usuariosDto;
        }

        public LoginResult Login(string username, string password)
        {
            Usuario usuario = _usuarioRepository.GetByUserame(username);

            if (usuario == null) { return LoginResult.InvalidUsername; }

            var encripted = Encryption.Encrypt(password);

            if (usuario.Password != encripted) { return LoginResult.InvalidPassword; }

            _sesion.Login(usuario);

            return LoginResult.ValidUser;
        }

        public void LogOut()
        {
            var user = _sesion.Usuario;

            _sesion.Logout();
        }
    }
}