namespace PD.Entities
{
    public class Factura : BaseEntity
    {
        public List<FacturaDetalle> Detalle { get; set; }
        public Guid ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteCuit { get; set; }
        public decimal IngresosBrutos { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
    }
}