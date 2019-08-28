using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SchoolTrackerCs
{
    class ConnectSQL
    {
        static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static public void BuildConnectionString()
        {
            // Build connection
            
            builder.DataSource = "qunication.database.windows.net";
            builder.InitialCatalog = "Qu";
            builder.UserID = "Quuu";
            builder.Password = "Takemymoney7";
      
        }

        static public void Connect()
        {
            // Connect to SQL

            Console.WriteLine("Connecting to SQL server");
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                Console.WriteLine("Connection succesfull\n");
            }
        }

        static public void Disconnect()
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
