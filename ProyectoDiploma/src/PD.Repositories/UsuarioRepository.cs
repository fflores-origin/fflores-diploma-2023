using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Entities.Permisos;
using PD.Repositories.Interfaces;
using System.Data.SqlClient;

namespace PD.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConnection _connection;
        private readonly IConfiguration _configuration;

        public UsuarioRepository(IConnection connection, IConfiguration configuration)
        {
            _connection = connection;
            _configuration = configuration;
        }

        public void Create(string username, string password)
        {
            using var connection = _connection.CreateConnection();
            connection.Open();

            var list = new List<Usuario>();
            SqlTransaction tran;
            tran = connection.BeginTransaction();
            try
            {
                var query = "INSERT INTO Usuario(Nombre,Password) values(@nombre,@password)";

                using (var cmd = new SqlCommand(query, connection, tran))
                {
                    cmd.Parameters.AddWithValue("@nombre", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    var reader = cmd.ExecuteNonQuery();
                    tran.Commit();
                }
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw (ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Usuario> GetAll()
        {
            using var connection = _connection.CreateConnection();
            connection.Open();

            var list = new List<Usuario>();

            try
            {
                var query = "SELECT * FROM Usuario";

                using (var cmd = new SqlCommand(query, connection))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(
                        new Usuario()
                        {
                            Id = Guid.Parse(reader["Id"].ToString()),
                            Email = reader["Email"].ToString(),
                            IdiomaId = Guid.Parse(reader["IdiomaId"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            Password = reader["Password"].ToString(),
                        }
                        );
                    };
                }
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }

        public List<Patente> GetAllPantente()
        {
            var list = new List<Patente>();
            using var connection = _connection.CreateConnection();
            connection.Open();

            try
            {
                var query = @"SELECT top(1)
                                u.*,
                                i.Nombre as IdiomaNombre,
                                i.IsoCode ,
                                i.IsDefault
                              FROM Usuario u
                              join Idioma i on u.IdiomaId = i.Id
                              WHERE u.Nombre = @username";
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { connection.Close(); }

            return (list);
        }

        public Usuario GetByUserame(string username)
        {
            using var connection = _connection.CreateConnection();
            connection.Open();

            Usuario user = null;

            try
            {
                var query = @"SELECT top(1)
                                u.*,
                                i.Nombre as IdiomaNombre,
                                i.IsoCode ,
                                i.IsDefault
                              FROM Usuario u
                              join Idioma i on u.IdiomaId = i.Id
                              WHERE u.Nombre = @username";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new Usuario()
                        {
                            Id = Guid.Parse(reader["Id"].ToString()),
                            Email = reader["Email"].ToString(),
                            IdiomaId = Guid.Parse(reader["IdiomaId"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            Password = reader["Password"].ToString(),
                            Idioma = new Idioma()
                            {
                                Id = Guid.Parse(reader["IdiomaId"].ToString()),
                                Nombre = reader["IdiomaNombre"].ToString(),
                                IsoCode = reader["IsoCode"].ToString(),
                                IsDefault = Convert.ToBoolean(reader["IsDefault"])
                            }
                        };
                    };
                }
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                connection.Close();
            }

            return user;
        }

        public void GetByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}