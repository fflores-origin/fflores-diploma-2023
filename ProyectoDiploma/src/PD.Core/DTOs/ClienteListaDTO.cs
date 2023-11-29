namespace PD.Core.DTOs
{
    public class ClienteListaDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Guid TipoDocumentoId { get; set; }

        public Guid TipoClienteId { get; set; }

        public string TipoCliente { get; set; }
        public string TipoDocumento { get; set; }
    }
}