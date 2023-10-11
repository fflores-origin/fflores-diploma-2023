using PD.Core.DTOs;
using PD.Core.Mappers.Interfaces;
using PD.Entities;

namespace PD.Core.Mappers
{
    public class UsuariosMapper : IUsuariosMapper
    {
        public Usuario Map(UsuarioDto dto)
        {
            throw new NotImplementedException();
        }

        public UsuarioDto Map(Usuario entity)
        {
            return new UsuarioDto() { Id = entity.Id, NombreUsuario = entity.NombreUsuario };
        }

        public List<UsuarioDto> Map(List<Usuario> usuarios)
        {
            var list = new List<UsuarioDto>();

            return usuarios
                .Select(x =>
                    new UsuarioDto()
                    {
                        Id = x.Id,
                        NombreUsuario = x.NombreUsuario
                    })
                .ToList();
        }
    }
}