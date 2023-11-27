﻿using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
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
                            Id = Guid.Parse(item["id"].ToString()),
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
            throw new NotImplementedException();
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

        public bool SaveOrUpdateIdioma(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrUpdateTraduccion(Traduccion idioma)
        {
            throw new NotImplementedException();
        }
    }
}