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
            var articulus = new List<Articulo>();

            using (SqlConnection conn = _connection.CreateConnection())
            {
                conn.Open();
                var query =
                    "SELECT * FROM Lista;" +
                    "SELECT l.*, a.Nombre, a.PrecioUnitario from ListaArticulo l join Articulo a on a.Id = l.ArticuloId;";

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
                            Porcentaje = Convert.ToDecimal(item["Porcentaje"].ToString()),
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

                        listaArticulo.Articulo = new Articulo()
                        {
                            Id = listaArticulo.ArticuloId,
                            Nombre = item["Nombre"].ToString(),
                            PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"].ToString())
                        };

                        var lista = list
                            .Where(x => x.Id == listaArticulo.ListaId)
                            .FirstOrDefault();

                        listaArticulo.Lista = lista;

                        if (lista != null) lista.Articulos.Add(listaArticulo);
                    }
                }
            }

            return list;
        }

        private List<Lista> GetListas()
        {
            var list = new List<Lista>();
            using (SqlConnection conn = _connection.CreateConnection())
            {
                conn.Open();
                var query = "SELECT * FROM Lista;";

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
                            Porcentaje = Convert.ToDecimal(item["Porcentaje"].ToString()),
                            Articulos = new List<ListaArticulo>()
                        });
                    }
                }
            }

            return list;
        }

        public void UpdateArticuloLista(Articulo articulo)
        {
            var listas = GetAll();
            var articuloLista = listas.SelectMany(x => x.Articulos.Where(x => x.ArticuloId == articulo.Id));

            using (SqlConnection conn = _connection.CreateConnection())
            {
                conn.Open();

                var query = "";

                if (articuloLista.Any())
                {
                    query = @"UPDATE LA
                              SET LA.Precio = (A.PrecioUnitario * (L.Porcentaje /100)) + A.PrecioUnitario
                              FROM ListaArticulo LA
                              JOIN Articulo A ON LA.ArticuloId = A.Id
                              JOIN Lista L ON LA.ListaId = L.Id
                              WHERE A.Lista;";
                   
                }
                else
                {
                    query = "insert into ListaArticulo(Id, ArticuloId, ListaId, Precio) VALUES";
                    foreach (var li in listas)
                    {
                        var precioLista = articulo.PrecioUnitario * (li.Porcentaje / 100) + articulo.PrecioUnitario;
                        query += $"(NEWID(),'{articulo.Id}','{li.Id}', {precioLista}),";
                    }

                    query = query.Substring(0, query.Length - 1); // remuevo ultima coma
                }

                using SqlCommand cmd = new(query, conn);

                cmd.ExecuteNonQuery();
            }
        }
    }
}