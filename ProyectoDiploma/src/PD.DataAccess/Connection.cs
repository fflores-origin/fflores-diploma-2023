using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using System.Data.SqlClient;

namespace PD.DataAccess
{
    public class Connection : IConnection
    {
        private readonly string _connectionString;

        public Connection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("defaultConnection");
        }

        public SqlConnection CreateConnection() => new(_connectionString);

        public SqlCommand CreateStoreCommand(string query, SqlConnection connection, SqlTransaction? transaction = null)
            => new(query, connection, transaction) { CommandType = System.Data.CommandType.StoredProcedure };
    }
}