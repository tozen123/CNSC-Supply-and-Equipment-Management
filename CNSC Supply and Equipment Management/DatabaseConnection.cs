using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CNSC_Supply_and_Equipment_Management
{

    public class DatabaseConnection
    {
        private string connectionString = $"Server=localhost;Database=cnscsupplyandequipmentmanagementdb;User ID=root;Password=''";
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }


        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }


        public void InsertData(string tableName, Dictionary<string, object> data)
        {
            var columns = string.Join(", ", data.Keys);
            var values = string.Join(", ", data.Keys.Select(key => "@" + key));
            var query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";

            var parameters = data.Select(d => new MySqlParameter("@" + d.Key, d.Value)).ToArray();
            ExecuteNonQuery(query, parameters);
        }


        public void DeleteData(string tableName, string condition, Dictionary<string, object> parameters)
        {
            string query = $"DELETE FROM {tableName} WHERE {condition} ";
            var sParams = parameters.Select(d => new MySqlParameter(d.Key, d.Value)).ToArray();
            ExecuteNonQuery(query, sParams);
        }
        public void ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateData(string tableName, string setClause, string condition, Dictionary<string, object> parameters)
        {
            string query = $"UPDATE {tableName} SET {setClause} WHERE {condition} ";
            var sParams = parameters.Select(d => new MySqlParameter(d.Key, d.Value)).ToArray();
            ExecuteNonQuery(query, sParams);
        }
    }
}
