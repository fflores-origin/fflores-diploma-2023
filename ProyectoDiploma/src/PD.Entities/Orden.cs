namespace PD.Entities
{
    public class Orden : BaseEntity
    {
        public Proveedor Proveedor { get; set; }
        public Guid ProveedorId { get; set; }
        public DateTime Fecha { get; set; }
        public Guid ClienteId { get; set; }
        public Guid TipoOrdenId { get; set; }

        public Cliente Cliente { get; set; }
        public TipoOrden TipoOrden { get; set; }
        public List<Articulo> Articulos { get; set; }
    }
}