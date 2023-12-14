using System.Data.SqlClient;

namespace PD.DataAccess.Interfaces
{
    public interface IConnection
    {
        SqlConnection CreateConnection();

        SqlCommand CreateStoreCommand(string query, SqlConnection connection, SqlTransaction? transaction = null);

        SqlCommand CreateTextCommand(string query, SqlConnection connection, SqlTransaction? transaction = null);
    }
}