using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IList<Cliente> GetAll();
        List<TipoCliente> GetAllTipoCliente();
        List<TipoDocumento> GetAllTipoDocumento();
        Cliente Save(Cliente cliente);
    }
}