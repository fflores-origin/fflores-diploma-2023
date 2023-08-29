using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;
using System.Data.SqlClient;
using System.Reflection;

namespace PD.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntidadBase
    {
        private readonly IConnection _connection;

        public Repository(IConnection connection)
        {
            _connection = connection;
        }

        public void Delete(Guid id)
        {
            using (var connection = _connection.GetConnection())
            {
                var properties = typeof(T).GetProperties();
            }
        }

        public T Get(Guid id)
        {
            using var connection = _connection.GetConnection();
            connection.Open();
            T result = default(T);

            try
            {
                var query = $"SELECT * FROM {GetPluralTableName()} WHERE Id = '{id}'";
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
            using var connection = _connection.GetConnection();
            connection.Open();

            var list = new List<T>();

            try
            {
                var query = $"SELECT * FROM {GetPluralTableName()}";
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                while (reader.Read()) { list.Add(GetObject(reader)); };
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
            Type type = typeof(T);
            var properties = type.GetProperties();
            var instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo prop in properties)
            {
                if (!Equals(reader[prop.Name], DBNull.Value)) prop.SetValue(instance, reader[prop.Name], null);
            }

            return instance;
        }

        private static string GetPluralTableName()
            => typeof(T).Name + "s";
    }
}