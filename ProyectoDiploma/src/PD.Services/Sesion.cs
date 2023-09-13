using PD.Entities;
using PD.Entities.Enums;

namespace PD.Services
{
    public class Sesion
    {
        private Usuario _usuario;

        public Usuario Usuario
        { get { return _usuario; } }

        public void Login(Usuario usuario)
        {
            _usuario = usuario;
        }

        public void Logout() => _usuario = null; // TODO: Hacer Usuario Disposable

        public bool IsLogged() => _usuario != null;

        private bool IsInRole(PermisoBase p, TipoPermiso tipoPermiso, bool valid)
        {
            foreach (var item in p.ObtenerHijos())
            {
                if (item is Patente && ((Patente)item).Tipo.Equals(tipoPermiso))
                {
                    valid = true;
                }
                else
                {
                    valid = IsInRole(item, tipoPermiso, valid);
                }
            }
            return valid;
        }

        public bool HasRole(TipoPermiso tipoPermiso)
        {
            if (_usuario == null) return false;

            bool valid = false;
            foreach (var permiso in _usuario.Permisos)
            {
                if (permiso is Patente && ((Patente)permiso).Tipo.Equals(tipoPermiso))
                {
                    valid = true;
                }
                else
                {
                    valid = IsInRole(permiso, tipoPermiso, valid);
                }
            }

            return valid;
        }
    }
}