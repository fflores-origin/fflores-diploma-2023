using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace PD.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IConnection _connection;

        public PedidoRepository(IConfiguration configuration, IConnection connection)
        {
            _configuration = configuration;
            _connection = connection;
        }

        public List<Pedido> GetAll()
        {
            var list = new List<Pedido>();

            using (var conn = _connection.CreateConnection())
            {
                conn.Open();

                var query = "PedidosGetAll";

                using SqlCommand cmd = new(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                using SqlDataAdapter da = new(cmd);
                using DataSet ds = new();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        list.Add(new Pedido { });
                    }
                }
            }

            return list;
        }

        public Pedido GetById(Guid id)
        {
            var list = new List<Pedido>();

            using (var conn = _connection.CreateConnection())
            {
                conn.Open();

                var query = "PedidosGet";

                using SqlCommand cmd = new(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                using SqlDataAdapter da = new(cmd);
                using DataSet ds = new();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        list.Add(new Pedido { });
                    }
                }
            }

            return list.FirstOrDefault();
        }

        public Pedido Save(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}