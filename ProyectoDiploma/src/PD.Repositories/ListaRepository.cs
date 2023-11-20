using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace PD.Repositories
{
    public class ListaRepository : IListaRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IConnection _connection;

        public ListaRepository(
            IConnection connection,
            IConfiguration configuration)
        {
            _connection = connection;
            _configuration = configuration;
        }

        public IList<Lista> GetAll()
        {
            var list = new List<Lista>();

            using (SqlConnection conn = _connection.CreateConnection())
            {
                conn.Open();
                var query = "SELECT * FROM Lista; " +
                    "SELECT * from ListaArticulo;";
                using SqlCommand cmd = new(query, conn);
                using SqlDataAdapter da = new(cmd);
                using DataSet ds = new();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        list.Add(new Lista()
                        {
                            Id = Guid.Parse(item["id"].ToString()),
                            Nombre = item["Nombre"].ToString(),
                            Articulos = new List<ListaArticulo>()
                        });
                    }
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[1].Rows)
                    {
                        var listaArticulo = new ListaArticulo()
                        {
                            Id = Guid.Parse(item["id"].ToString()),
                            ArticuloId = Guid.Parse(item["ArticuloId"].ToString()),
                            ListaId = Guid.Parse(item["ListaId"].ToString()),
                            Precio = decimal.Parse(item["Precio"].ToString())
                        };

                        var lista = list
                            .Where(x => x.Id == listaArticulo.ListaId)
                            .FirstOrDefault();

                        if (lista != null) lista.Articulos.Add(listaArticulo);
                    }
                }
            }

            return list;
        }
    }
}