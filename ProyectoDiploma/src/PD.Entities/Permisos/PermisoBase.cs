namespace PD.Entities.Permisos
{
    public abstract class PermisoBase : BaseEntity //permisoBase
    {
        public string Nombre { get; set; }

        public abstract void AddPermiso(PermisoBase permiso);

        public abstract void RemovePermiso(PermisoBase permiso);

        public abstract IList<PermisoBase> ObtenerHijos();

        public override string ToString() => Nombre;
    }
}