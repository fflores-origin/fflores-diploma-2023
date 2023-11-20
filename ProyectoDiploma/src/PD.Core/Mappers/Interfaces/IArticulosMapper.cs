using PD.Core.DTO;
using PD.Core.DTOs.Articulo;
using PD.Entities;

namespace PD.Core.Mappers.Interfaces
{
    public interface IArticulosMapper : IMapper<Articulo, ArticuloListaDTO>
    {
        List<ArticuloListaDTO> GetArticuloListas(List<Articulo> articulos);

        Articulo GetArticulo(ArticuloDTO dto);
    }
}