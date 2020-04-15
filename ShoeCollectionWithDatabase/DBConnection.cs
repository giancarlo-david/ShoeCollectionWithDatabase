using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShoeCollectionWithDatabase
{
    public static class DBConnection
    {
        // Function to connect to the school SQL Database
        public static SqlConnection GetConnection()
        {
            // Uses SQL Connection object along with the a string to establish a connection
            SqlConnection connection = null;
            string connectionString = "Data Source=DESKTOP-26F7ACP\\SQLEXPRESS2019;" +
                "Initial Catalog=ShoeCollection;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
