namespace PD.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public Guid TipoDocumentoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }
}