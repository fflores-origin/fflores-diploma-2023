namespace PD.Entities
{
    public class Cliente : EntidadBase
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public Guid TipoDocumentoId { get; set; }
        TipoDocumento TipoDocumento { get; set; }
    }
}