namespace PD.Entities
{
    public class Grupo : PermisoBase
    {
        public Grupo()
        {
            _permisos = new List<PermisoBase>();
        }

        private IList<PermisoBase> _permisos;

        public override IList<PermisoBase> Permisos
        { get { return _permisos.ToArray(); } }

        public override void AgregarPermiso(PermisoBase permiso) => _permisos.Add(permiso);

        public override void LimpiarPermisos() => _permisos.Clear();
    }
}