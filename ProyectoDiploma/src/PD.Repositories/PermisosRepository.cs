using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using System.Data.SqlClient;

namespace PD.Repositories
{
    public class PermisosRepository : IPermisosRepository
    {
        private readonly IConnection _connection;

        public PermisosRepository(IConnection connection)
        {
            _connection = connection;
        }

        public List<Grupo> GetGrupos()
        {
            var grupos = new List<Grupo>();

            using (var conn = _connection.CreateConnection())
            {
                conn.Open();
                var qry = "SELECT * FROM ";

                using (var cmd = new SqlCommand(qry, conn))
                {

                }
            }

            return new List<Grupo>();
        }

        public List<Permiso> GetPermisos()
        {
            return new List<Permiso>();
        }
    }
}