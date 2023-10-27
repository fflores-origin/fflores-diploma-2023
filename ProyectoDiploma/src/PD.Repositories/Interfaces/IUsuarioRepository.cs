using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        void Create(string username, string password);

        List<Usuario> GetAll();

        Usuario GetByUserame(string username);

        void GetByUsername(string username);
    }
}