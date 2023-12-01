using PD.Core.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class PedidosManager : IPedidosManager
    {
        private readonly IPedidoRepository _repository;

        public PedidosManager(
            IPedidoRepository repository)
        {
            _repository = repository;
        }

        public List<Pedido> GetAll()
        {
            return _repository.GetAll();
        }
    }
}