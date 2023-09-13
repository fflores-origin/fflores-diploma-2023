using PD.Entities;
using PD.Entities.Enums;
using PD.Services.Interfaces;

namespace PD.Services
{
    public class Sesion
    {
        private Usuario _usuario;

        private static IList<ILanguageObserver> _observers = new List<ILanguageObserver>();

        public Usuario Usuario
        { get { return _usuario; } }

        #region User Access

        public void Login(Usuario usuario)
        {
            _usuario = usuario;
        }

        public void Logout() => _usuario = null; // TODO: Hacer Usuario Disposable

        public bool IsLogged() => _usuario != null;

        private bool IsInRole(PermisoBase p, TipoPermiso tipoPermiso, bool isValid)
        {
            foreach (var item in p.ObtenerHijos())
            {
                if (item is Patente && ((Patente)item).Tipo.Equals(tipoPermiso))
                {
                    isValid = true;
                }
                else
                {
                    isValid = IsInRole(item, tipoPermiso, isValid);
                }
            }
            return isValid;
        }

        public bool IsInRole(TipoPermiso tipoPermiso)
        {
            if (_usuario == null) return false;

            bool isValid = false;

            foreach (var permiso in _usuario.Permisos)
            {
                if (permiso is Patente && ((Patente)permiso).Tipo.Equals(tipoPermiso))
                {
                    isValid = true;
                }
                else
                {
                    isValid = IsInRole(permiso, tipoPermiso, isValid);
                }
            }

            return isValid;
        }

        #endregion User Access

        #region Language

        public static void SubscribeObserver(ILanguageObserver languageObserver)
            => _observers.Add(languageObserver);

        public static void UnsubscribeObserver(ILanguageObserver languageObserver)
            => _observers.Remove(languageObserver);

        //TODO: pasar a un servicio
        public static void NotifyChange(string isoCode)
            => _observers.ToList().ForEach(x => x.OnLanguageChanged(isoCode));

        //TODO: ChangeLanguage en Sesion con un factory

        #endregion Language
    }
}