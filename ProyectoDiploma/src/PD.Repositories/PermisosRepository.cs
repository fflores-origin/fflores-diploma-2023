using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Entities.Enums;
using PD.Entities.Permisos;
using PD.Repositories.Interfaces;
using PD.Repositories.Utils;
using System.Data;
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

        public IList<PermisoBase> GetAllComponentes(Guid? id)
        {
            using (var conn = _connection.CreateConnection())
            {
                conn.Open();

                var query = "PermisosGetAll";
                using var cmd = _connection.CreateStoreCommand(query, conn);

                if (id != Guid.Empty) cmd.Parameters.AddWithValue("@familiaId", id);
                else cmd.Parameters.AddWithValue("@familiaId", null);

                using SqlDataAdapter da = new(cmd);
                using DataSet ds = new();
                var lista = new List<PermisoBase>();

                da.Fill(ds);

                if (ds.HasRows())
                {
                    foreach (DataRow row in ds.Rows())
                    {
                        Guid padreId = Guid.Empty;

                        if (row["PermisoPadreId"] != DBNull.Value)
                            padreId = row["PermisoPadreId"].AsGuid();

                        string permiso = null;
                        if (row["TipoPermiso"] != DBNull.Value)
                            permiso = row["TipoPermiso"].ToString();

                        PermisoBase permisoBase = string.IsNullOrEmpty(permiso)
                            ? new Familia()
                            {
                                Id = row["Id"].AsGuid(),
                                Nombre = row["Nombre"].ToString()
                            }
                            : new Patente()
                            {
                                Id = row["Id"].AsGuid(),
                                Nombre = row["Nombre"].ToString(),
                                Tipo = row["TipoPermiso"].AsEnum<TipoPermiso>()
                            };

                        var padre = GetComponent(padreId, lista);

                        if (padre == null) lista.Add(permisoBase);
                        else padre.AddPermiso(permisoBase);
                    }

                    return lista;
                }
            }

            throw new NotImplementedException();
        }

        private PermisoBase GetComponent(Guid id, IList<PermisoBase> permisos)
        {
            PermisoBase? component = permisos?
                .Where(i => i.Id.Equals(id))
                .FirstOrDefault();

            if (component == null && permisos != null)
            {
                foreach (var permiso in permisos)
                {
                    var comp = GetComponent(id, permiso.ObtenerHijos());
                    if (comp != null && comp.Id == id)
                        return comp;
                    else
                    if (comp != null)
                        return GetComponent(id, comp.ObtenerHijos());
                }
            }

            return component;
        }

        public List<Familia> GetGrupos()
        {
            List<Familia> grupos = new();

            using var conn = _connection.CreateConnection();
            conn.Open();
            var qry = "FamiliaGetAll";

            using var cmd = _connection.CreateStoreCommand(qry, conn);
            using SqlDataAdapter da = new(cmd);
            using DataSet ds = new();

            da.Fill(ds);

            if (ds.HasRows())
            {
                foreach (DataRow row in ds.Rows())
                {
                    grupos.Add(new Familia()
                    {
                        Id = row["Id"].AsGuid(),
                        Nombre = row["Nombre"].ToString(),
                    });
                }
            }

            return grupos;
        }

        public List<Patente> GetPermisos()
        {
            List<Patente> patentes = new();

            using var conn = _connection.CreateConnection();
            conn.Open();

            var qry = "PatenteGetAll";

            using var cmd = _connection.CreateStoreCommand(qry, conn);
            using SqlDataAdapter da = new(cmd);
            using DataSet ds = new();

            da.Fill(ds);

            if (ds.HasRows())
            {
                foreach (DataRow row in ds.Rows())
                {
                    patentes.Add(new Patente()
                    {
                        Id = row["Id"].AsGuid(),
                        Nombre = row["Nombre"].ToString(),
                        Tipo = row["TipoPermiso"].AsEnum<TipoPermiso>()
                    });
                }
            }

            return patentes;
        }

        public PermisoBase SaveComponent(PermisoBase patente, bool esFamilia)
        {
            using var conn = _connection.CreateConnection();
            conn.Open();

            var query = "PermisoSave";
            using var cmd = _connection.CreateStoreCommand(query, conn);

            if (patente.Id == Guid.Empty)
                patente.Id = Guid.NewGuid();

            cmd.Parameters.AddWithValue("@nombre", patente.Nombre);
            cmd.Parameters.AddWithValue("@id", patente.Id);

            cmd.ExecuteNonQuery();

            return patente;
        }

        public Familia SaveFamilia(Familia familia)
        {
            return familia;
        }

        public void FillPermisoUsuario(Usuario usuario)
        {
            using var conn = _connection.CreateConnection();
            conn.Open();
            var qry = "PermisoUsuarioGetAll";

            using var cmd = _connection.CreateStoreCommand(qry, conn);
        }
    }
}