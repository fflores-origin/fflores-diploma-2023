﻿using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using PD.Repositories.Utils;
using System.Data;
using System.Data.SqlClient;

namespace PD.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IConnection _connection;

        public LanguageRepository(
            IConfiguration configuration,
            IConnection connection)
        {
            _configuration = configuration;
            _connection = connection;
        }

        public bool Delete(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        public IList<Idioma> GetAllIdiomas()
        {
            var list = new List<Idioma>();

            using (SqlConnection conn = _connection.CreateConnection())
            {
                conn.Open();
                var query = "SELECT * FROM Idioma";
                using SqlCommand cmd = new(query, conn);
                using SqlDataAdapter da = new(cmd);
                using DataSet ds = new();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        list.Add(new Idioma()
                        {
                            Id = item["id"].AsGuid(),
                            Nombre = item["Nombre"].ToString(),
                            IsoCode = item["IsoCode"].ToString(),
                            IsDefault = Convert.ToBoolean(item["IsDefault"])
                        });
                    }
                }
            }

            return list;
        }

        public IDictionary<string, Traduccion> GetAllTraduccionByIdioma(Idioma? idioma)
        {
            var traducciones = new Dictionary<string, Traduccion>();

            //TraduccionGetAllByIdioma

            using (SqlConnection conn = _connection.CreateConnection())
            {
                conn.Open();
                var query = "TraduccionGetAllByIdioma";
                using SqlCommand cmd = new(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                using SqlDataAdapter da = new(cmd);
                using DataSet ds = new();

                cmd.Parameters.AddWithValue("@id", idioma.Id);

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var key = row["Nombre"].ToString();

                        var value = new Traduccion()
                        {
                            IdiomaId = Guid.Parse(row["IdiomaId"].ToString()),
                            EtiquetaId = Guid.Parse(row["EtiquetaId"].ToString()),
                            Valor = row["Valor"].ToString(), //tradu
                            Etiqueta = new Etiqueta()
                            {
                                Id = Guid.Parse(row["EtiquetaId"].ToString()),
                                Nombre = row["Nombre"].ToString()
                            },
                            Idioma = idioma
                        };

                        traducciones.Add(key, value);
                    }
                }
            }

            return traducciones;
        }

        public IList<Traduccion> GetAllTraducciones()
        {
            throw new NotImplementedException();
        }

        public Idioma GetById(Guid idiomaId)
        {
            throw new NotImplementedException();
        }

        public Idioma GetDefault()
        {
            throw new NotImplementedException();
        }

        public Idioma SaveOrUpdateIdioma(Idioma idioma)
        {
            string query;

            if (idioma.Id == Guid.Empty)
            {
                idioma.Id = Guid.NewGuid();
                query = "IdiomaCreate";
            }
            else
            {
                query = "IdiomaUpdate";
            }

            using SqlConnection conn = _connection.CreateConnection();
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            try
            {
                using SqlCommand cmd = _connection.CreateTextCommand(query, conn, tran);

                cmd.Parameters.AddWithValue("@Id", idioma.Id);
                cmd.Parameters.AddWithValue("@Valor", idioma.Nombre);
                cmd.Parameters.AddWithValue("@IsoCode", idioma.IsoCode);
                cmd.Parameters.AddWithValue("@IsDefault", idioma.IsDefault);

                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
            }

            return idioma;
        }

        public bool SaveOrUpdateTraduccion(Traduccion idioma)
        {
            throw new NotImplementedException();
        }
    }
}