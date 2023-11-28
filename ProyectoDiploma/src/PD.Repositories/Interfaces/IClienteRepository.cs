using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IList<Cliente> GetAll();

        Cliente Save(Cliente cliente);
    }
}