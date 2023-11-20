namespace PD.Entities
{
    public class Lista : BaseEntity
    {
        public string Nombre { get; set; }

        public List<ListaArticulo> Articulos { get; set; }
    }
}