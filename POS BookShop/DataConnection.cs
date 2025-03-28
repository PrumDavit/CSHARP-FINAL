using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_BookShop
{
    internal class DataConnection
    {
        public static SqlConnection DataCon { get; set; }
        private static string Server = "LAPTOP-EULTBQQA\\MSSQLSERVERSOVAN";
        private static string Database = "dbo_bookstore";
        private static string User = "sa";
        private static string Password = "123";
        public static void ConnectionDB()
        {
            try
            {
                string connectionString = ($"Server={Server};Database={Database};User={User};Password={Password}");
                DataCon = new SqlConnection(connectionString);
                DataCon.Open();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error connecting to database: {ex.Message}");
            }
        }
    }
}
