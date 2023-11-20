using PD.Entities.Permisos;

namespace PD.Entities
{
    public class Usuario : BaseEntity
    {
        private IList<PermisoBase> _permisos;

        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid IdiomaId { get; set; }
        public Idioma Idioma { get; set; }

        public Usuario()
        {
            _permisos = new List<PermisoBase>();
        }

        public IList<PermisoBase> Permisos
        { get { return _permisos; } }

        public override string ToString() => Nombre;
    }
}