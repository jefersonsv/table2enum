using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace table2enum
{
    public static class Connection
    {
        //
        public static Dictionary<int, string> List(string cs, string tableName, string idColumnName, string descriptionColumnName)
        {
            using (var cnn = new SqlConnection(cs))
            {
                var q = cnn.Query<KeyValuePair<int, string>>($"SELECT {idColumnName} AS ID, {descriptionColumnName} AS DESCRIPTION FROM {tableName}");

                return new Dictionary<int, string>();
            }
        }
    }
}