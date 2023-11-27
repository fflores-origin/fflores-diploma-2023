using PD.Entities;

namespace PD.Services.Interfaces
{
    public interface ILanguageObserver
    {
        void OnLanguageChanged(Idioma idioma);
    }
}