namespace PD.Entities
{
    public class Almacen : BaseEntity
    {
        public Articulo Articulo { get; set; }
        public Guid ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public bool Fisico { get; set; }
        public string Ubicacion { get; set; }
    }
}