using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SchoolTrackerCs
{
    class SQLConnectionTool
    {
        static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static public void BuildConnectionString()
        {
            // Build connection
            
            builder.DataSource = "sql.itcn.dk\\TCAA";
            builder.InitialCatalog = "quan00272.SKOLE";
            builder.UserID = "quan0027.SKOLE";
            builder.Password = "1q5tC72MdM";
      
        }

        static public void ConnectSQL()
        {
            // Connect to SQL

            Console.WriteLine("Connecting to SQL server");
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                Console.WriteLine("Connection succesfull\n");
            }
        }

        static public void DisconnectSQL()
        {
            Console.WriteLine("Disconnecting SQL server");
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Close();
                Console.WriteLine("Disconnecting successfull");
            }
        }
    }
        
        

            
}
