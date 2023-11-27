namespace PD.Entities
{
    public class Idioma : BaseEntity
    {
        public string Nombre { get; set; }
        public string IsoCode { get; set; }
        public bool IsDefault { get; set; }
    }
}