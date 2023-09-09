using PD.Entities.Enums;

namespace PD.Entities
{
    public abstract class PermisoBase : BaseEntity
    {
        public string Nombre { get; set; }

        public abstract void AddPermiso(PermisoBase permiso);
        public abstract void RemovePermiso(PermisoBase permiso);
        public abstract IList<PermisoBase> ObtenerHijos();

        //public abstract void LimpiarPermisos();

        //public TipoPermiso TipoPermiso { get; set; }

        public override string ToString() => this.Nombre;
    }
}