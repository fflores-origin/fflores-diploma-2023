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
        private readonly IUsuariosMapper _usuariosMapper;
        private readonly Sesion _sesion;

        public UsuarioManager(
            IUsuarioRepository usuarioRepository,
            IUsuariosMapper usuariosMapper,
            IPermisosRepository permisosRepository)
        {
            _usuarioRepository = usuarioRepository;
            _usuariosMapper = usuariosMapper;
            _sesion = UserSesion.Session;
            _permisosRepository = permisosRepository;
        }

        #region Usuario

        public void CrearUsuario(string username, string password)
        {
            _usuarioRepository.Create(username, Encryption.Encrypt(password));
        }

        public List<UsuarioDto> GetUsuarios()
        {
            var usuarios = _usuarioRepository.GetAll();
            var usuariosDto = _usuariosMapper.Map(usuarios);
            return usuariosDto;
        }

        #endregion Usuario

        #region Sesion

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

        #endregion Sesion

        #region Permisos

        public bool PatenteExiste(PermisoBase permiso, PermisoBase patente)
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

        public void SaveFamilia(PermisoBase familiaSeleccionada)
        {
            throw new NotImplementedException();
        }

        public List<PermisoBase> GetAllComponentes(Familia familia = null)
        {
            if (familia != null)
            {
                var permisosPorFamilia = _permisosRepository.GetAllComponentes(familia.Id).ToList();
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

        public void CompleteComponent(Familia familia)
        {
            familia.ClearPermisos();
            var permisos = _permisosRepository.GetAllComponentes(familia.Id);

            foreach (var p in permisos)
            {
                familia.AddPermiso(p);
            }
        }

        #endregion Permisos
    }
}