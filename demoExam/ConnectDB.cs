using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace demoExam
{
    public class ConnectDB : IDisposable
    {
        SqlConnection _connection;
        string _connectionString = @"Data Source = LAYBRINGWIN\MSSQLSERVER01; Initial Catalog = demoExam; Integrated Security = true";

        public ConnectDB()
        {
            ConnectionOpen();
        }

        public void ConnectionOpen()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void ConnectionClose()
        {
            _connection.Close();
        }

        public DataTable ExecuteSql(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, _connection);
            var reader = cmd.ExecuteReader();
            dt.Load(reader);

            return dt;
        }

        public void ExecuteSqlNonQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            ConnectionClose();
        }
    }
}
