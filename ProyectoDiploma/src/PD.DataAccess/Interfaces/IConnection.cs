using System.Data.SqlClient;

namespace PD.DataAccess.Interfaces
{
    public interface IConnection
    {
        SqlConnection CreateConnection();
    }
}