using PD.Core.DTO;
using PD.Core.DTOs.Articulo;
using PD.Entities;

namespace PD.Core.Interfaces
{
    public interface IArticulosManager
    {
        List<ArticuloListaDTO> GetList();

        Articulo CrearArticulo(ArticuloDTO dto);

      
    }
}