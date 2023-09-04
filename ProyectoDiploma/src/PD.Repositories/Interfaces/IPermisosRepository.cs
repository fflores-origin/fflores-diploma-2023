using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface IPermisosRepository
    {
        List<Permiso> GetPermisos();
        List<Grupo> GetGrupos();
    }
}