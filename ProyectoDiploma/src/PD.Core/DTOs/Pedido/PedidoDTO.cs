namespace PD.Core.DTOs.Pedido
{
    public class PedidoDTO
    {
        public Guid NroPedido { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadItems { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
    }
}