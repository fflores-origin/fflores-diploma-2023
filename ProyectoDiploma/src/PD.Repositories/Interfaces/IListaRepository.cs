using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface IListaRepository
    {
        IList<Lista> GetAll();
        Lista Save(Lista lista);
        void UpdateArticuloLista(Articulo articulo);
    }
}