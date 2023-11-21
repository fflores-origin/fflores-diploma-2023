namespace PD.Core.DTOs.Articulo
{
    public class ArticuloDTO : BaseDto
    {
        public Guid? Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Marca { get; set; }
        public Guid CategoriaId { get; set; }
        public int Cantidad { get; set; }
        public string Ubicacion { get; set; }
        public string Codigo { get; set; }
        public string ImagePath { get; set; }

        public List<ListaArticuloDTO> Listas { get; set; }
    }
}