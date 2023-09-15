using PD.Entities.Enums;

namespace PD.Entities.Permisos
{
    public class Patente : PermisoBase
    {
        public TipoPermiso Tipo { get; set; }

        public override void AddPermiso(PermisoBase permiso)
        {
            throw new NotImplementedException();
        }

        public override IList<PermisoBase> ObtenerHijos()
        {
            return new List<PermisoBase>();
        }

        public override void RemovePermiso(PermisoBase permiso)
        {
            throw new NotImplementedException();
        }
    }
}