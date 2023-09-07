namespace PD.Entities
{
    public class ArticuloListaDTO : BaseEntity
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        

        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}