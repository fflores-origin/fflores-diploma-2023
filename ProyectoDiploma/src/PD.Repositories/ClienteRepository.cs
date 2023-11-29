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

            var query = "ClienteGetAll";

            using (var conn = _connection.CreateConnection())
            {
                conn.Open();

                using (var cmd = new SqlCommand(query, conn))
                {
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
                                Nombre = item["TipoClienteNombre"].ToString(),
                                Tipo = item["TipoCliente"].ToString(),
                            };

                            var tipoDocumento = new TipoDocumento()
                            {
                                Id = Guid.Parse(item["TipoDocumentoId"].ToString()),
                                Nombre = item["TipoDocumentoNombre"].ToString(),
                            };

                            var cliente = new Cliente()
                            {
                                Id = Guid.Parse(item["id"].ToString()),
                                Nombre = item["Nombre"].ToString(),
                                Documento = item["Documento"].ToString(),
                                Direccion = item["Direccion"].ToString(),
                                Email = item["Email"].ToString(),
                                Telefono = item["Telefono"].ToString(),
                                TipoDocumentoId = Guid.Parse(item["TipoDocumentoId"].ToString()),
                                TipoClienteId = Guid.Parse(item["TipoClienteId"].ToString()),
                                TipoDocumento = tipoDocumento,
                                TipoCliente = tipoCliente,
                            };

                            list.Add(cliente);
                        }
                    }
                }
            }

            return list;
        }

        public List<TipoCliente> GetAllTipoCliente()
        {
            var list = new List<TipoCliente>();

            var query = "SELECT * from TipoCliente";

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
                            list.Add(new TipoCliente()
                            {
                                Id = Guid.Parse(item["Id"].ToString()),
                                Nombre = item["Nombre"].ToString(),
                                Tipo = item["Tipo"].ToString(),
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<TipoDocumento> GetAllTipoDocumento()
        {
            var list = new List<TipoDocumento>();

            var query = "SELECT * from TipoDocumento";

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
                            list.Add(new TipoDocumento()
                            {
                                Id = Guid.Parse(item["Id"].ToString()),
                                Nombre = item["Nombre"].ToString(),
                            });
                        }
                    }
                }
            }

            return list;
        }

        public Cliente Save(Cliente cliente)
        {
            string? query;

            if (cliente.Id == Guid.Empty)
            {
                cliente.Id = Guid.NewGuid();
                query = "ClienteCreate";
            }
            else
            {
                query = "ClienteUpdate";
            }
            using (var conn = _connection.CreateConnection())
            {
                conn.Open();

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", cliente.Id);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
                    cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@TipoDocumentoId", cliente.TipoDocumentoId);
                    cmd.Parameters.AddWithValue("@TipoClienteId", cliente.TipoClienteId);

                    cmd.ExecuteNonQuery();
                }
            }

            return cliente;
        }
    }
}