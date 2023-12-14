using PD.Entities;

namespace PD.Core.Interfaces
{
    public interface IIdiomaManager
    {
        Idioma GetDefault();

        List<Idioma> GetIdiomas();

        IDictionary<string, Traduccion> GetTraducciones(Idioma idioma);

        Idioma Save(Idioma selected);
    }
}