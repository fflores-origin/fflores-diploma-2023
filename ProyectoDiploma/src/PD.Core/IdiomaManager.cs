using PD.Core.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using PD.Services;

namespace PD.Core
{
    public class IdiomaManager : IIdiomaManager
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly Sesion _sesion;

        public IdiomaManager(
            ILanguageRepository languageRepository
            )
        {
            _sesion = UserSesion.Session;
            _languageRepository = languageRepository;
        }

        public Idioma GetDefault()
        {
            return GetIdiomas()
                .Where(x => x.IsDefault)
                .First();
        }

        public List<Idioma> GetIdiomas()
        {
            return _languageRepository.GetAllIdiomas().ToList();
        }

        public IDictionary<string, Traduccion> GetTraducciones(Idioma idioma)
        {
            if (idioma == null)
            {
                idioma = GetDefault();
            }

            return _languageRepository.GetAllTraduccionByIdioma(idioma);
        }
    }
}