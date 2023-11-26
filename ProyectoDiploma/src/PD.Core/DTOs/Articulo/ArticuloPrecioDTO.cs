namespace PD.Core.DTOs.Articulo
{
    public class ArticuloPrecioDTO
    {

        public Guid Id { get; set; }

        public Guid ArticuloId { get; set; }
        public string Nombre { get; set; }
        
        public Guid ListaId { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioLista { get; set; }
    }
}