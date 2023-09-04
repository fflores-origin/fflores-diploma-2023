using PD.Entities.Enums;

namespace PD.Entities
{
    public abstract class PermisoBase : BaseEntity
    {
        public string Nombre { get; set; }
        public abstract IList<PermisoBase> Permisos { get; }

        public abstract void AgregarPermiso(PermisoBase permiso);

        public abstract void LimpiarPermisos();

        public TipoPermiso TipoPermiso { get; set; }

        public override string ToString() => Nombre;
    }
}