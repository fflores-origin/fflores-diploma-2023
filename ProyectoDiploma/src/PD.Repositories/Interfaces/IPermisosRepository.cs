using PD.Entities;

namespace PD.Repositories.Interfaces
{
    public interface IPermisosRepository
    {
        List<Patente> GetPermisos();
        List<Familia> GetGrupos();
    }
}