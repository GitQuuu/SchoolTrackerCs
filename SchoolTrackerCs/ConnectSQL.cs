﻿using System;
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
        /// <summary>
        /// Method to INSERT INTO database table for students
        /// </summary>
        /// <param name="student">Insert which parameter the method will have access too</param>
        static public void BuildSqlCommandMember(Student student)
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                
                // "InsertIDIntoOtherTable is a SQL store procedure we parse into our parameter"
                using (SqlCommand command = new SqlCommand("InsertIDIntoOtherTable", connection))
                {
                    connection.Open();

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TableIDStore", 1);
                    command.Parameters.AddWithValue("@firstName", $"{student.FirstName}");
                    command.Parameters.AddWithValue("@lastName", $"{student.LastName}");
                    command.Parameters.AddWithValue("@Grade", $"{student.Grade}");
                    command.Parameters.AddWithValue("@address", $"{student.Address}");
                    command.Parameters.AddWithValue("@CPR", $"{student.CPR}");
                    command.Parameters.AddWithValue("@phoneNumber", $"{student.PhoneNumber}");
                    command.Parameters.AddWithValue("@email", $"{student.Email}");

                    int result = command.ExecuteNonQuery();

                    connection.Close();
                }

            }
       
        }
        /// <summary>
        /// Method to INSERT INTO database table for teachers
        /// </summary>
        /// <param name="teacher">Insert which parameter the method will have access too</param>
        static public void BuildSqlCommandMember(Teacher teacher)
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("InsertIDIntoOtherTable", connection))
                {
                    connection.Open();

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TableIDStore", 2);
                    command.Parameters.AddWithValue("@firstName", $"{teacher.FirstName}");
                    command.Parameters.AddWithValue("@lastName", $"{teacher.LastName}");
                    command.Parameters.AddWithValue("@TeacherSalary", $"{teacher.Salary}");
                    command.Parameters.AddWithValue("@TeacherSpecials", $"{teacher.Specials}");
                    command.Parameters.AddWithValue("@address", $"{teacher.Address}");
                    command.Parameters.AddWithValue("@CPR", $"{teacher.CPR}");
                    command.Parameters.AddWithValue("@phoneNumber", $"{teacher.PhoneNumber}");
                    command.Parameters.AddWithValue("@email", $"{teacher.Email}");

                    int result = command.ExecuteNonQuery();

                    connection.Close();
                }

            }

        }

     




      
    }      
}
