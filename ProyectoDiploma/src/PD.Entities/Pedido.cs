namespace PD.Entities
{
    public class Pedido : BaseEntity
    {
        public Guid ClienteId { get; set; }
        public Guid ListaId { get; set; }

        public List<PedidoDetalle> Detalles { get; set; }
        public Cliente Cliente { get; set; }
        public Lista Lista { get; set; }
    }
}