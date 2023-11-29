using PD.Core.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteManager(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll().ToList();
        }

        public List<TipoCliente> GetAllTipoClientes()
        {
            return _clienteRepository.GetAllTipoCliente();
        }

        public List<TipoDocumento> GetAllTipoDocumentos()
        {
            return _clienteRepository.GetAllTipoDocumento();
        }

        public Cliente SaveOrCreate(Cliente selected)
        {
            return _clienteRepository.Save(selected);
        }
    }
}