using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        List<Pedido> GetAll();

        Pedido GetById(Guid id);

        Pedido Save(Pedido pedido);
    }
}