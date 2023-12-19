namespace PD.Entities
{
    public class Pedido : BaseEntity
    {
        public Pedido()
        {
            Detalles = new List<PedidoDetalle>();
        }

        public Guid ClienteId { get; set; }
        public Guid ListaId { get; set; }
        public DateTime Fecha { get; set; }
        public List<PedidoDetalle> Detalles { get; set; }
        public Cliente Cliente { get; set; }
        public Lista Lista { get; set; }
    }
}