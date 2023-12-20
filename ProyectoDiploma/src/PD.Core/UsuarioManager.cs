using PD.Core.DTOs;
using PD.Core.Interfaces;
using PD.Core.Mappers.Interfaces;
using PD.Entities;
using PD.Entities.Enums;
using PD.Entities.Permisos;
using PD.Repositories.Interfaces;
using PD.Services;
using PD.Services.Enums;

namespace PD.Core
{
    public class UsuarioManager : IUsuarioManager
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPermisosRepository _permisosRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly IUsuariosMapper _usuariosMapper;
        private readonly Sesion _sesion;

        public UsuarioManager(
            IUsuarioRepository usuarioRepository,
            IUsuariosMapper usuariosMapper,
            ILanguageRepository languageRepository,
            IPermisosRepository permisosRepository)
        {
            _usuarioRepository = usuarioRepository;
            _usuariosMapper = usuariosMapper;
            _sesion = UserSesion.Session;
            _languageRepository = languageRepository;
            _permisosRepository = permisosRepository;
        }

        public void CrearUsuario(string username, string password)
        {
            _usuarioRepository.Create(username, Encryption.Encrypt(password));
        }

        public List<PermisoBase> GetAllComponentes(Familia familia = null)
        {
            if (familia != null)
            {
                var permisosPorFamilia = _permisosRepository.GetAllComponentes(id).ToList();
                foreach (var permiso in permisosPorFamilia)
                {
                    familia.AddPermiso(permiso);
                }
                return familia.ObtenerHijos().ToList();
            }

            return new List<PermisoBase>();
        }

        public List<Familia> GetAllFamilias()
        {
            List<Familia> familias = _usuarioRepository.GetAllFamilias();
            return familias;
        }

        public List<Patente> GetAllPatentes()
        {
            List<Patente> pantentes = _usuarioRepository.GetAllPantente();
            return pantentes;
        }

        public Array GetAllPermisos()
        {
            return Enum.GetValues(typeof(TipoPermiso));
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

        public bool PatenteExiste(PermisoBase permiso, Patente patente)
        {
            bool existe = false;

            if (permiso.Id.Equals(patente.Id))
            {
                existe = true;
            }
            else
            {
                foreach (var item in permiso.ObtenerHijos().ToList())
                {
                    if (PatenteExiste(item, patente)) return true;
                }
            }

            return existe;
        }

        public PermisoBase SaveComponent(PermisoBase patente, bool esFamilia)
        {
            return _permisosRepository.SaveComponent(patente, esFamilia);
        }
    }
}