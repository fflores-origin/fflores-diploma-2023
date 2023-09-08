using PD.Core.DTO;
using PD.Core.Mappers.Interfaces;
using PD.Entities;

namespace PD.Core.Mappers
{
    public class ArticulosMapper : IArticulosMapper
    {
        public List<ArticuloListaDTO> GetArticuloListas(List<Articulo> articulos)
        {
            var list = new List<ArticuloListaDTO>();
            articulos.ForEach(articulo => list.Add(Map(articulo)));
            return list;
        }

        public Articulo Map(ArticuloListaDTO dto)
        {
            throw new NotImplementedException();
        }

        public ArticuloListaDTO Map(Articulo entity)
        {
            return new ArticuloListaDTO()
            {
                Id = entity.Id,
                Codigo = entity.Codigo,
                Descripcion = entity.Descripcion,
                Nombre = entity.Nombre,
                Imagen = entity.Imagen
            };
        }
    }
}