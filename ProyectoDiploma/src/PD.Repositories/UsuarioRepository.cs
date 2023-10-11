using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
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
            throw new NotImplementedException();
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
                            NombreUsuario = reader["NombreUsuario"].ToString(),
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

        public Usuario GetByUserame(string username)
        {
            throw new NotImplementedException();
        }

        public void GetByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}