namespace PD.Entities
{
    public class Usuario : EntidadBase
    {
        private List<Permiso> _permisos;
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public Idioma Idioma { get; set; }

        public Usuario()
        {
            _permisos = new List<Permiso>();
        }

        public List<Permiso> Permisos
        { get { return _permisos; } }

        public override string ToString() => Nombre;
    }
}