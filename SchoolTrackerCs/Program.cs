using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.Sql;


namespace SchoolTrackerCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to School tracker\n");

            //ConnectSQL.BuildConnectionString();
            //ConnectSQL.Connect();
            

            List<Student> students = new List<Student>();
            //List<Teacher> teachers = new List<Teacher>();
           
            //char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            
            bool studentLoopState = true;
            //bool teacherLoopState = true;

            while (studentLoopState)
            {
                ///Instantiating an object from Student class so we can access its content
                
                Student newStudent = new Student();

                //newStudent.FirstName = Utility.ExcludeSymbols("Student name", digits);
                //newStudent.LastName = Utility.ExcludeSymbols("Student lastname",digits);
                newStudent.Grade = Utility.AskInt("Student grade");
                //newStudent.Grade = int.Parse(Console.ReadLine());
                //newStudent.CPR = Utility.CPR("Student CPR - dd/mm/year/serial number");
                //newStudent.Address = Utility.Ask("Student address");
                //newStudent.PhoneNumber = Utility.AskInt("Student phone number");
                //newStudent.Email = Utility.ValidateEmail("Student email");

                /////Add to our Database
                //ConnectSQL.BuildSqlCommandMember(newStudent);


                /// To add our newStudent object to our list
                /// 
                students.Add(newStudent);

                ///To keep track of the amount of objects added to the Student class list students
                ///
                Student.Count++;
                Console.WriteLine($"Students in list:{Student.Count}");


                Console.WriteLine("add another? y/n");
                if (Console.ReadLine() != "y")
                {
                    studentLoopState = false;
                }
            }

            //while (teacherLoopState)
            //{

            //    if (Utility.Ask("add a(nother) teacher? y/n?") == "y")
            //    {
            //        Teacher newTeacher = new Teacher();

            //        newTeacher.FirstName = Utility.ExcludeSymbols("Teacher first name", digits);
            //        newTeacher.LastName = Utility.ExcludeSymbols("Teacher last name", digits);
            //        newTeacher.Salary = Utility.AskDecimal("Teacher salary pr hour");
            //        newTeacher.Specials = Utility.Ask("Which subject is the Teacher special");
            //        newTeacher.Address = Utility.Ask("Teacher address");
            //        newTeacher.Email = Utility.ValidateEmail("Teacher email address");
            //        newTeacher.PhoneNumber = Utility.AskInt("Teacher phone number");
            //        newTeacher.CPR = Utility.Ask("Teacher cpr");

            //        ConnectSQL.BuildSqlCommandMember(newTeacher);

            //        teachers.Add(newTeacher);

            //        Teacher.Count++;
            //        Console.WriteLine($"Teacher in list:{Teacher.Count}");

            //    }
            //    else
            //    {
            //        teacherLoopState = false;
            //    }
                
            //}

            foreach (Student student in students)
            {
                Console.WriteLine($"\nStudents counts:{students.IndexOf(student) + 1}");
                student.Display();
            }
            //foreach (Teacher teacher in teachers)
            //{
            //    Console.WriteLine($"\nTeachers counts:{teachers.IndexOf(teacher) + 1}");
            //    teacher.Display();
            //}
            
            
            
            Console.ReadLine();

        }
    }
}
    

