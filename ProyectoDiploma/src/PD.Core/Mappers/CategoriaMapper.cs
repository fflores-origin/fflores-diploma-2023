using PD.Core.DTOs;
using PD.Core.Mappers.Interfaces;
using PD.Entities;

namespace PD.Core.Mappers
{
    public class CategoriaMapper : ICategoriaMapper
    {
        public CategoriaMapper()
        {
        }

        public List<CategoriaDto> Map(List<Categoria> categorias)
        {
            var list = new List<CategoriaDto>();
            foreach (var categoria in categorias)
            {
                list.Add(new CategoriaDto()
                {
                    Id = categoria.Id,
                    Nombre = categoria.Nombre,
                });
            }
            return list;
        }
    }
}