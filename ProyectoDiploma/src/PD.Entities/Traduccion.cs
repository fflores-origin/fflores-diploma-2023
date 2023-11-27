namespace PD.Entities
{
    public class Traduccion
    {
        public Guid IdiomaId { get; set; }
        public Guid EtiquetaId { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public Idioma Idioma { get; set; }
        public string Valor { get; set; }
    }
}