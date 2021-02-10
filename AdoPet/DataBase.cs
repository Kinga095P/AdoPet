using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AdoPet
{
    class DataBase
    {
        public string _connectionString;

        public DataBase(string adresSerwera, string nazwaBazyDanych)
        {
            _connectionString = $"Data Source={adresSerwera}; Initial Catalog={nazwaBazyDanych}; Integrated Security=true";
        }
        public DataRowCollection SelectQuery(string query, List<SqlParameter> parameters=null)

        {
            DataRowCollection dr;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    foreach(var parametr in parameters)
                    {
                        cmd.Parameters.Add(parametr);
                    }
                }
                cmd.CommandType = CommandType.Text;
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);
                dr = dataSet.Tables[0].Rows;
            }
            return dr;
        }
        public void ExecuteQuery(string query, List<SqlParameter> parameters=null)
        {
            using(SqlConnection connection= new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                if(parameters!=null)
                {
                    foreach(var parametr in parameters)
                    {
                        cmd.Parameters.Add(parametr);
                    }
                }
                connection.Open();
                cmd.CommandType =CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
