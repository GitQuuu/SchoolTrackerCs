using System;
using System.Collections.Generic;

namespace SchoolTrackerCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to School tracker\n");
            /// making a single list of our class Student 
            /// 
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();

            ///Defining an array for our failsafe method CheckStringForElement to use as a parameter like on line 32
            ///This char array will be used to check the string for not having the values inside the elements
            ///This allow our CheckStringForElement to be flexibel , we could just instantiate a new array og any desired type and 
            ///parse in which desired value we want to check the string for
            char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] email = new char[] { '@' };

            bool studentLoopState = true;
            bool teacherLoopState = true;

            /*while (studentLoopState)
            {
                ///Instantiating an object from Student class so we can access its content
                ///
                Student newStudent = new Student();

                newStudent.Name = Utility.ExcludeSymbols("Student name", digits);
                newStudent.Grade = Utility.AskInt("Student grade");
                newStudent.Birthday = Utility.Ask("Student birthday dates");
                newStudent.Address = Utility.Ask("Student address");
                newStudent.PhoneNumber = Utility.AskInt("Student phone number");

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
            }*/

            while (teacherLoopState)
            {

                if (Utility.Ask("add a(nother) teacher? y/n?") == "y")
                {
                    Teacher newTeacher = new Teacher();

                    //newTeacher.Name = Utility.ExcludeSymbols("Teacher name", digits);
                    //newTeacher.Salary = Utility.AskDecimal("Teacher salary pr hour");
                    //newTeacher.Specials = Utility.Ask("Which subject is the Teacher special");
                    //newTeacher.Address = Utility.Ask("Teacher address");
                    newTeacher.Email = Utility.ValidateEmail("Teacher email address");
                    newTeacher.PhoneNumber = Utility.AskInt("Teacher phone number");
                    //newTeacher.Birthday = Utility.Ask("Teacher birth date");

                    teachers.Add(newTeacher);

                    Teacher.Count++;
                    Console.WriteLine($"Teacher in list:{Teacher.Count}");

                }
                else
                {
                    teacherLoopState = false;
                }

            }


            foreach (Student student in students)
            {
                Console.WriteLine($"\nStudents counts:{students.IndexOf(student) + 1}");
                student.Display();
            }
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"\nTeachers counts:{teachers.IndexOf(teacher) + 1}");
                teacher.Display();
            }

            Console.ReadLine();

        }
    }
}
    

