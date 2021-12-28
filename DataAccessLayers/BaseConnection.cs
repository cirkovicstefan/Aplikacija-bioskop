using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class BaseConnection
    {
        private static SqlConnection sqlConnection = null;

        public static SqlCommand GetSqlCommand(string query)
        {
            try
            {
                sqlConnection = new SqlConnection(Constant.Constant.ConnectionString);
                sqlConnection.Open();
                return new SqlCommand(query, sqlConnection);
            }
            catch
            {
                return new SqlCommand();
            }
        }

        public static bool ExecuteNonQuerySqlCommand(string query)
        {
            try
            {
                SqlCommand sqlCommand = GetSqlCommand(query);
                int result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return result > 0;
            }
            catch { return false; }
        }

        public static object ExecuteScalarSqlCommand(string query)
        {
            try
            {
                SqlCommand sqlCommand = GetSqlCommand(query);
                object o = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
                return o;
            }
            catch
            {
                return new object();
            }
        }

    }
}
