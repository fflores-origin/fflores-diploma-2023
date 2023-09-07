namespace PD.Entities
{
    public class Almacen : BaseEntity
    {
        public ArticuloListaDTO Articulo { get; set; }
        public Guid ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public bool Fisico { get; set; }
    }
}