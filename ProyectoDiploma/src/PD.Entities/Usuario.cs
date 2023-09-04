namespace PD.Entities
{
    public class Usuario : BaseEntity
    {
        private List<PermisoBase> _permisos;
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public Idioma Idioma { get; set; }

        public Usuario()
        {
            _permisos = new List<PermisoBase>();
        }

        public List<PermisoBase> Permisos
        { get { return _permisos; } }

        public override string ToString() => Nombre;
    }
}