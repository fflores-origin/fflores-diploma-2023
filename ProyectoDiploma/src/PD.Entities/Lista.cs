namespace PD.Entities
{
    public class Lista : BaseEntity
    {
        public string Nombre { get; set; }
        public Guid ArticuloId { get; set; }
        public decimal Precio { get; set; }

        public Articulo Articulo { get; set; }
    }
}