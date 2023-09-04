namespace PD.Entities
{
    public class Permiso : PermisoBase
    {
        public override IList<PermisoBase> Permisos
        { get { return new List<PermisoBase>(); } }

        public override void AgregarPermiso(PermisoBase permiso)
        {
        }

        public override void LimpiarPermisos()
        { }
    }
}