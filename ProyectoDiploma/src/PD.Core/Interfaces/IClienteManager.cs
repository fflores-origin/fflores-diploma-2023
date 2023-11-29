using PD.Entities;

namespace PD.Core.Interfaces
{
    public interface IClienteManager
    {
        List<Cliente> GetAll();

        List<TipoCliente> GetAllTipoClientes();

        List<TipoDocumento> GetAllTipoDocumentos();

        Cliente SaveOrCreate(Cliente selected);
    }
}