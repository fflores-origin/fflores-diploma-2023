using PD.Entities.Enums;
using System.Data;

namespace PD.Repositories.Utils
{
    public static class SqlExtensions
    {
        public static T AsEnum<T>(this object value)
            => (T)Enum.Parse(typeof(TipoPermiso), value.ToString());

        public static Guid AsGuid(this object value)
            => Guid.Parse(value.ToString());

        public static bool HasRows(this DataSet set, int table = 0)
            => set.Tables[table].Rows.Count > 0;

        public static DataRowCollection Rows(this DataSet set, int table = 0)
            => set.Tables[table].Rows;
    }
}