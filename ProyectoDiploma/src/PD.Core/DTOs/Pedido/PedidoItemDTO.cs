namespace PD.Core.DTOs.Pedido
{
    public class PedidoItemDTO
    {
        public Guid Id { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal Total { get; set; }
    }
}