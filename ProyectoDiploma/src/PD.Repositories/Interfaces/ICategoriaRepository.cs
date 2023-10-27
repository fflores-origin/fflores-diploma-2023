using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IList<Categoria> GetAll();
    }
}