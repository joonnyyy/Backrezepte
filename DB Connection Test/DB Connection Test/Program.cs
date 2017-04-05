using System;
using System.Data;
using System.Data.SqlClient;
namespace database_demo1
{
    class MainClass
    {
        public static void Main(string[] args)
        {//lol
            // http://www.connectionstrings.com/sql-server/
            // use "." for local server like: '.\myInstanceName'
            string connectionString = @"Server=192.168.56.101;Database=testdb;User Id=Admin;Password=12345678;";
            SqlConnection connection; SqlCommand command;
            string sql = null; SqlDataReader dataReader;
   
            sql = "Select * From test";
            connection = new SqlConnection(connectionString);
            try {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read()) {
                    Console.WriteLine(dataReader.GetValue(0) + " - " + dataReader.GetValue(1));
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Can not open connection !: " + ex.Message);
            }
            Console.Read();
        }
    }
}