using PD.Core.DTO;

namespace PD.Core.Interfaces
{
    public interface IArticulosManager
    {
        List<ArticuloListaDTO> GetList();
    }
}