using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using System.Data.SqlClient;

namespace PD.DataAccess
{
    public class Connection : IConnection
    {
        private readonly string _connectionString;
        private readonly SqlConnection _connection;

        public Connection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("data");
        }
    }
}