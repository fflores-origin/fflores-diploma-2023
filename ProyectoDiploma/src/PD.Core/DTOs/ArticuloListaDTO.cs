using PD.Core.DTOs;

namespace PD.Core.DTO
{
    public class ArticuloListaDTO : BaseDto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
}