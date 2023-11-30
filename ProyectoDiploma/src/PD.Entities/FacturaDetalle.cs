namespace PD.Entities
{
    public class FacturaDetalle
    {
        public Guid FacturaId { get; set; }
        public Guid ArticuloId { get; set; }
        public Articulo Articulo { get; set; }
        public string ArticuloNombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}