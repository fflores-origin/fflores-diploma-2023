using PD.Entities.Permisos;

namespace PD.Repositories.Interfaces
{
    public interface IPermisosRepository
    {
        List<Patente> GetPermisos();

        List<Familia> GetGrupos();

        PermisoBase SaveComponent(PermisoBase patente, bool esFamilia);
    }
}