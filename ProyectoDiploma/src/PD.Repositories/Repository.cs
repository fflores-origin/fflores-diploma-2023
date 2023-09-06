using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace PD.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IConnection _connection;

        public Repository(IConnection connection)
        {
            _connection = connection;
        }

        public void Delete(Guid id)
        {
            using (var connection = _connection.CreateConnection())
            {
                var properties = typeof(T).GetProperties();
            }
        }

        public T Get(Guid id)
        {
            using var connection = _connection.CreateConnection();
            connection.Open();
            T result = default(T);

            try
            {
                // TODO: agregar join con complejos
                var joins = "";
                var query = $"SELECT * FROM {GetPluralTableName<T>()} as base WHERE Id = '{id}'";
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows) { result = GetObject(reader); };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public IQueryable<T> GetAll()
        {
            using var connection = _connection.CreateConnection();
            connection.Open();

            var list = new List<T>();

            try
            {
                var query = CreateQuery();

                using (var cmd = new SqlCommand(query, connection))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read()) { list.Add(GetObject(reader)); };
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                connection.Close();
            }

            return list.AsQueryable();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        private static T GetObject(SqlDataReader reader)
        {
            var properties = GetProperties<T>();
            var instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo prop in properties)
            {
                if (IsPropertyComplex(prop))
                {
                    var type = prop.PropertyType;

                    var subInstance = Activator.CreateInstance(type);
                    var subProps = type.GetProperties();
                    
                    foreach (var subProp in subProps)
                    {
                        if (!Equals(reader[$"{prop.Name}{subProp.Name}"], DBNull.Value)) 
                            subProp.SetValue(subInstance, reader[$"{prop.Name}{subProp.Name}"], null);
                    }

                    prop.SetValue(instance, subInstance);
                    
                }
                else
                {
                    if (!Equals(reader[prop.Name], DBNull.Value)) prop.SetValue(instance, reader[prop.Name], null);
                }
            }

            return instance;
        }

        private static string CreateQuery()
        {
            var addedColumns = "";
            var properties = GetProperties<T>();

            var joins = new StringBuilder();
            var indexJoiner = 1;
            foreach (var prop in properties)
            {
                if (IsPropertyComplex(prop))
                {
                    addedColumns = GetColumnsComplex(prop, indexJoiner, prop.Name);
                    joins = joins.AppendLine($"\nJOIN {GetPluralTableName(prop.Name)} P{indexJoiner} ON P{indexJoiner}.Id = orig.{prop.Name}Id");
                    indexJoiner++;
                }
            }

            var query = $"SELECT orig.* " +
                $"{addedColumns}" +
                $"FROM {GetPluralTableName<T>()} orig" +
                $"{joins}";

            return query;
        }

        private static PropertyInfo[] GetProperties<T>()
            => typeof(T).GetProperties();

        private static string GetColumnsComplex(PropertyInfo propType, int index, string tableName)
        {
            var columns = new StringBuilder();

            var properties = propType.PropertyType.GetProperties().Where(x => x.Name != "Id");

            properties.ToList().ForEach(p => { columns.AppendLine($",P1.{p.Name} as {tableName}{p.Name}"); });

            return columns.ToString();
        }

        private static bool IsPropertyComplex(PropertyInfo property)
            => property.PropertyType.BaseType?.Name == "BaseEntity";

        private static string GetPluralTableName<T>()
            => typeof(T).Name + "s";

        private static string GetPluralTableName(string value)
            => $"{value}s";
    }
}