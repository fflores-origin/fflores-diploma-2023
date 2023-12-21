namespace PD.Entities.Permisos
{
    public class Familia : PermisoBase
    {
        private IList<PermisoBase> _permisos;

        public Familia()
        {
            _permisos = new List<PermisoBase>();
        }

        public override void AddPermiso(PermisoBase permiso)
        {
            if (!_permisos.Contains(permiso))
                _permisos.Add(permiso);
        }

        public void ClearPermisos()
        {
            _permisos = new List<PermisoBase>();
        }

        public override IList<PermisoBase> ObtenerHijos()
        {
            return _permisos.ToList();
        }

        public override void RemovePermiso(PermisoBase permiso)
        {
            if (_permisos.Contains(permiso))
                _permisos.Remove(permiso);
        }
    }
}