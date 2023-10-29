using PD.Core.DTOs;
using PD.Entities;

namespace PD.Core.Mappers.Interfaces
{
    public interface ICategoriaMapper
    {
        List<CategoriaDto> Map(List<Categoria> categorias);
    }
}