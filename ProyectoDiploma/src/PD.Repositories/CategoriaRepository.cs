using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using PD.Repositories.Utils;
using System.Data;
using System.Data.SqlClient;

namespace PD.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IConnection _connection;

        public CategoriaRepository(
            IConfiguration configuration,
            IConnection connection)
        {
            _configuration = configuration;
            _connection = connection;
        }

        public IList<Categoria> GetAll()
        {
            var list = new List<Categoria>();

            using (SqlConnection conn = _connection.CreateConnection())
            {
                conn.Open();
                var query = "SELECT * FROM Categoria";
                using SqlCommand cmd = new(query, conn);
                using SqlDataAdapter da = new(cmd);
                using DataSet ds = new();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        list.Add(new Categoria()
                        {
                            Id = item["id"].AsGuid(),
                            Nombre = item["Nombre"].ToString()
                        });
                    }
                }
            }

            return list;
        }
    }
}