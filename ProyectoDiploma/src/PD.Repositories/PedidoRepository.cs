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
                        var tipoCliente = new TipoCliente()
                        {
                            Id = Guid.Parse(item["TipoClienteId"].ToString()),
                            Nombre = item["TipoClienteNombre"].ToString()
                        };

                        var tipoDocumento = new TipoDocumento()
                        {
                            Id = Guid.Parse(item["TipoDocumentoId"].ToString()),
                            Nombre = item["TipoDocumentoNombre"].ToString()
                        };

                        var cliente = new Cliente()
                        {
                            Id = Guid.Parse(item["ClienteId"].ToString()),
                            Nombre = item["Nombre"].ToString(),
                            Documento = item["Documento"].ToString(),
                            Direccion = item["Direccion"].ToString(),
                            Email = item["Email"].ToString(),
                            Telefono = item["Telefono"].ToString(),
                            TipoDocumentoId = Guid.Parse(item["TipoDocumentoId"].ToString()),
                            TipoClienteId = Guid.Parse(item["TipoClienteId"].ToString()),
                            TipoCliente = tipoCliente,
                            TipoDocumento = tipoDocumento
                        };

                        var lista = new Lista()
                        {
                            Id = Guid.Parse(item["ListaId"].ToString()),
                        };

                        list.Add(new Pedido
                        {
                            Id = Guid.Parse(item["Id"].ToString()),
                            ClienteId = Guid.Parse(item["ClienteId"].ToString()),
                            ListaId = Guid.Parse(item["ListaId"].ToString()),
                            Cliente = cliente,
                            Lista = lista
                        });
                    }
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        var categoria = new Categoria()
                        {
                            Id = Guid.Parse(item["CategoriaId"].ToString()),
                            Nombre = item["CategoriaNombre"].ToString(),
                        };

                        var articulo = new Articulo()
                        {
                            Id = Guid.Parse(item["ArticuloId"].ToString()),
                            Nombre = item["Nombre"].ToString(),
                            Codigo = item["Codigo"].ToString(),
                            CategoriaId = Guid.Parse(item["CategoriaId"].ToString()),
                            Descripcion = item["Descripcion"].ToString(),
                            Imagen = item["Imagen"].ToString(),
                            PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"].ToString()),
                            Marca = item["Marca"].ToString(),
                            Categoria = categoria,
                        };

                        var detalle = new PedidoDetalle()
                        {
                            PedidoId = Guid.Parse(item["PedidoId"].ToString()),
                            ArticuloId = Guid.Parse(item["ArticuloId"].ToString()),
                            Precio = Convert.ToDecimal(item["Precio"].ToString()),
                            Articulo = articulo
                        };

                        var pedido = list.Where(x => x.Id == detalle.PedidoId).FirstOrDefault();
                        pedido?.Detalles.Add(detalle);
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
                        var tipoCliente = new TipoCliente()
                        {
                            Id = Guid.Parse(item["TipoClienteId"].ToString()),
                            Nombre = item["TipoClienteNombre"].ToString()
                        };

                        var tipoDocumento = new TipoDocumento()
                        {
                            Id = Guid.Parse(item["TipoDocumentoId"].ToString()),
                            Nombre = item["TipoDocumentoNombre"].ToString()
                        };

                        var cliente = new Cliente()
                        {
                            Id = Guid.Parse(item["ClienteId"].ToString()),
                            Nombre = item["Nombre"].ToString(),
                            Documento = item["Documento"].ToString(),
                            Direccion = item["Direccion"].ToString(),
                            Email = item["Email"].ToString(),
                            Telefono = item["Telefono"].ToString(),
                            TipoDocumentoId = Guid.Parse(item["TipoDocumentoId"].ToString()),
                            TipoClienteId = Guid.Parse(item["TipoClienteId"].ToString()),
                            TipoCliente = tipoCliente,
                            TipoDocumento = tipoDocumento
                        };

                        var lista = new Lista()
                        {
                            Id = Guid.Parse(item["ListaId"].ToString()),
                        };

                        list.Add(new Pedido
                        {
                            Id = Guid.Parse(item["Id"].ToString()),
                            ClienteId = Guid.Parse(item["ClienteId"].ToString()),
                            ListaId = Guid.Parse(item["ListaId"].ToString()),
                            Cliente = cliente,
                            Lista = lista
                        });
                    }
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        var categoria = new Categoria()
                        {
                            Id = Guid.Parse(item["CategoriaId"].ToString()),
                            Nombre = item["CategoriaNombre"].ToString(),
                        };

                        var articulo = new Articulo()
                        {
                            Id = Guid.Parse(item["ArticuloId"].ToString()),
                            Nombre = item["Nombre"].ToString(),
                            Codigo = item["Codigo"].ToString(),
                            CategoriaId = Guid.Parse(item["CategoriaId"].ToString()),
                            Descripcion = item["Descripcion"].ToString(),
                            Imagen = item["Imagen"].ToString(),
                            PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"].ToString()),
                            Marca = item["Marca"].ToString(),
                            Categoria = categoria,
                        };

                        var detalle = new PedidoDetalle()
                        {
                            PedidoId = Guid.Parse(item["PedidoId"].ToString()),
                            ArticuloId = Guid.Parse(item["ArticuloId"].ToString()),
                            Precio = Convert.ToDecimal(item["Precio"].ToString()),
                            Articulo = articulo
                        };

                        var pedido = list.Where(x => x.Id == detalle.PedidoId).FirstOrDefault();
                        pedido?.Detalles.Add(detalle);
                    }
                }
            }

            return list.FirstOrDefault();
        }

        public Pedido Save(Pedido pedido)
        {
            string query;
            string queryDetalle;

            if (pedido.Id == Guid.Empty)
            {
                var id = Guid.NewGuid();
                pedido.Id = id;
                foreach (var pd in pedido.Detalles) pd.PedidoId = id;
                query = "PedidoSave";
                queryDetalle = "PedidoDetalleSave";
            }
            else
            {
                query = "PedidoUpdate";
                queryDetalle = "PedidoDetalleUpdate";
            }

            using (var conn = _connection.CreateConnection())
            {
                conn.Open();

                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    using SqlCommand cmd = new(query, conn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", pedido.Id);
                    cmd.Parameters.AddWithValue("@ClienteId", pedido.ClienteId);
                    cmd.Parameters.AddWithValue("@ListaId", pedido.ListaId);
                    cmd.ExecuteNonQuery();

                    pedido.Detalles.ForEach(detalle =>
                    {
                        using SqlCommand cmd = new(queryDetalle, conn, tran);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PedidoId", detalle.PedidoId);
                        cmd.Parameters.AddWithValue("@ArticuloId", detalle.ArticuloId);
                        cmd.Parameters.AddWithValue("@Precio", detalle.Precio);
                        cmd.ExecuteNonQuery();
                    });

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }

            return pedido;
        }
    }
}