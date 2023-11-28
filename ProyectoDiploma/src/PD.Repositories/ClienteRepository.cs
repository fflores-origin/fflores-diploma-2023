using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace PD.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IConnection _connection;

        public ClienteRepository(IConfiguration configuration, IConnection connection)
        {
            _configuration = configuration;
            _connection = connection;
        }

        public IList<Cliente> GetAll()
        {
            var list = new List<Cliente>();

            var query = "SELECT * from Cliente";

            using (var conn = _connection.CreateConnection())
            {
                conn.Open();

                using (var cmd = new SqlCommand(query, conn))
                {
                    using SqlDataAdapter da = new(cmd);
                    using DataSet ds = new();

                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow item in ds.Tables[0].Rows)
                        {
                            list.Add(new Cliente()
                            {
                                Id = Guid.Parse(item["id"].ToString()),
                                Nombre = item["Nombre"].ToString(),
                                Documento = item["Documento"].ToString(),
                                Email = item["Email"].ToString(),
                                TipoDocumentoId = Guid.Parse(item["TipoDocumentoId"].ToString()),
                            });
                        }
                    }
                }
            }

            return list;
        }

        public Cliente Save(Cliente cliente)
        {
            return cliente;
        }
    }
}