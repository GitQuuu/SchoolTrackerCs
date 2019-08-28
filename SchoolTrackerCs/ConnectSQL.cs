using System;
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

        static public void BuildSqlCommand(Student student)
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String query = "INSERT INTO dbo.Member(firstName,lastName,address,CPR,phoneNumber,email) VALUES(@firstName,@lastName,@address,@CPR,@phoneNumber,@email)";

                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@firstName", $"{student.FirstName}");
                    command.Parameters.AddWithValue("@lastName", $"{student.LastName}");
                    command.Parameters.AddWithValue("@address", $"{student.Address}");
                    command.Parameters.AddWithValue("@CPR", $"{student.CPR}");
                    command.Parameters.AddWithValue("@phoneNumber", $"{student.PhoneNumber}");
                    command.Parameters.AddWithValue("@email", $"{student.Email}");

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }

            }
       
        }

        static public void BuildSqlCommandGrade(Student student)
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String query = "INSERT INTO dbo.Student(StudentGrade) VALUES(@StudentGrade)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentGrade", $"{student.Grade}");

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }

            }

        }

        static public string BuildQuery(string tableName, Member member)
        {
            return $"INSERT INTO {tableName} VALUES({member.FirstName},{member.LastName},{member.Address},{member.CPR},{member.PhoneNumber},{member.Email})";
            
        }
    }
        
        

            
}
