using PD.Entities;
using PD.Entities.DTO;

namespace PD.Core.Interfaces
{
    public interface IArticulosManager
    {
        List<ArticulolistaDTO> GetList();
    }
}