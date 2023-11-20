namespace PD.Entities
{
    public class ListaArticulo : BaseEntity
    {
        public Guid ListaId { get; set; }
        public Guid ArticuloId { get; set; }
        public decimal Precio { get; set; }
        public Articulo Articulo { get; set; }
    }
}