using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface ILanguageRepository
    {
        IList<Idioma> GetAllIdiomas();

        Idioma GetById(Guid idiomaId);

        Idioma GetDefault();

        IDictionary<string, Traduccion> GetAllTraduccionByIdioma(Idioma? idioma);

        IList<Traduccion> GetAllTraducciones();

        bool SaveOrUpdateIdioma(Idioma idioma);

        bool SaveOrUpdateTraduccion(Traduccion idioma);

        bool Delete(Idioma idioma);
    }
}