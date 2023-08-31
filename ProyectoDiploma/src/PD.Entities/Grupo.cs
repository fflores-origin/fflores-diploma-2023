namespace PD.Entities
{
    public class Grupo : Permiso
    {
        public Grupo()
        {
            _permisos = new List<Permiso>();
        }

        private IList<Permiso> _permisos;

        public override IList<Permiso> Permisos
        { get { return _permisos.ToArray(); } }

        public override void AgregarPermiso(Permiso permiso) => _permisos.Add(permiso);

        public override void LimpiarPermisos() => _permisos.Clear();
    }
}