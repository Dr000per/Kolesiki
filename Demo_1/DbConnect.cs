using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo_1
{
    public class DbConnect
    {

        private static string Connections = @"Data Source = DESKTOP-BBAJL13\SQLEXPRESS; Initial Catalog = Demo1; Integrated Security = True;";
        SqlConnection connection = new SqlConnection(Connections);

        public void Open() 
        {

            if (connection.State == System.Data.ConnectionState.Closed)
            { 
            
                connection.Open();
            
            }
        
        }

        public void Close()
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {

                connection.Close();

            }

        }

        public SqlConnection GetSqlConnection() 
        {
        
            return connection;
        
        }

    }
}
