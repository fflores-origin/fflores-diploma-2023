namespace PD.Entities
{
    public class PedidoDetalle
    {
        public int Cantidad { get; set; }
        public Guid PedidoId { get; set; }
        public Guid ArticuloId { get; set; }
        public Articulo Articulo { get; set; }
        public decimal Precio { get; set; }
    }
}