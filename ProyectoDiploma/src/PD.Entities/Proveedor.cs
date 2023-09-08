namespace PD.Entities
{
    public class Proveedor : BaseEntity
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public Guid TipoDocumentoId { get; set; }
    }
}