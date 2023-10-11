using PD.Core.DTOs;
using PD.Entities;

namespace PD.Core.Mappers.Interfaces
{
    public interface IUsuariosMapper : IMapper<Usuario, UsuarioDto>
    {
        //UsuarioDto Map(Usuario usuario);

        List<UsuarioDto> Map(List<Usuario> usuarios);
    }
}