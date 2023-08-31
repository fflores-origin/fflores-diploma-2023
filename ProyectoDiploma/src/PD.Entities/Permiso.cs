using PD.Entities.Enums;

namespace PD.Entities
{
    public abstract class Permiso : EntidadBase
    {
        public string Nombre { get; set; }
        public abstract IList<Permiso> Permisos { get; }

        public abstract void AgregarPermiso(Permiso permiso);

        public abstract void LimpiarPermisos();

        public TipoPermiso TipoPermiso { get; set; }

        public override string ToString() => Nombre;
    }
}