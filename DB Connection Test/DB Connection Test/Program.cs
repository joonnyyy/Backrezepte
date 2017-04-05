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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string commandstring = "SELECT * FROM test";
                    SqlCommand command = new SqlCommand(commandstring, connection);
                    SqlDataReader reader;
                    connection.Open();
                    DataTable columns = connection.GetSchema("Columns");
                    foreach (DataRow row in columns.Rows)
                    {
                        Console.WriteLine(row["COLUMN_NAME"].ToString());
                        Console.WriteLine(row["TABLE_NAME"].ToString());
                    }
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["nr"] + "\t" + reader["name"] );
                    }
                    Console.ReadKey();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}