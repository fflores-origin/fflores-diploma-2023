using PD.Core.DTO;
using PD.Core.DTOs.Articulo;

namespace PD.Core.Interfaces
{
    public interface IArticulosManager
    {
        List<ArticuloListaDTO> GetList();

        void CrearArticulo(ArticuloDTO articulo);
    }
}