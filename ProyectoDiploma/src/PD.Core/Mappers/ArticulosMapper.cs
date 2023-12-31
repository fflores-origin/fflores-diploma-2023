﻿using PD.Core.DTO;
using PD.Core.DTOs.Articulo;
using PD.Core.Mappers.Interfaces;
using PD.Entities;

namespace PD.Core.Mappers
{
    public class ArticulosMapper : IArticulosMapper
    {
        public Articulo GetArticulo(ArticuloDTO dto)
        {
            return new Articulo()
            {
                Id = dto.Id.HasValue && dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id.Value,
                Codigo = dto.Codigo,
                CategoriaId = dto.CategoriaId,
                Imagen = dto.ImagePath,
                Descripcion = dto.Descripcion,
                Marca = dto.Marca,
                Nombre = dto.Nombre,
                PrecioUnitario = dto.PrecioUnitario,
                Autor = dto.Autor,
                Cantidad = dto.Cantidad,
                ISBN = dto.ISBN,
                Ubicacion = dto.Ubicacion
            };
        }

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