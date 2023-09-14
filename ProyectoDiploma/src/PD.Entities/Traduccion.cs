namespace PD.Entities
{
    public class Traduccion : BaseEntity
    {
        public Etiqueta Etiqueta { get; set; }
        public string Texto { get; set; }
    }
}