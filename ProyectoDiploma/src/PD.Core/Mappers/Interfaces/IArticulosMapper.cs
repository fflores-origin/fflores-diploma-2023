using PD.Core.DTO;
using PD.Entities;

namespace PD.Core.Mappers.Interfaces
{
    public interface IArticulosMapper : IMapper<Articulo, ArticuloListaDTO>
    {
        List<ArticuloListaDTO> GetArticuloListas(List<Articulo> articulos);
    }
}