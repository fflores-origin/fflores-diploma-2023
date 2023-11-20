using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface IListaRepository
    {
        IList<Lista> GetAll();
    }
}