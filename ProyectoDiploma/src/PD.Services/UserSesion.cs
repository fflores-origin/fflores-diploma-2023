namespace PD.Services
{
    public class UserSesion
    {
        private static Sesion _session;

        private UserSesion()
        {
        }

        public static Sesion Session
        {
            get { if (_session == null) { _session = new Sesion(); } return _session; }
        }
    }
}