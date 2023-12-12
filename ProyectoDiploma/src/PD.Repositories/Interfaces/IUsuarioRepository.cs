using PD.Entities;
using PD.Entities.Permisos;

namespace PD.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        void Create(string username, string password);

        List<Usuario> GetAll();

        List<Patente> GetAllPantente();

        Usuario GetByUserame(string username);

        void GetByUsername(string username);
    }
}