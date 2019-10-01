using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTrackerCs
{
    class  Student:Member
    {
        // This is to keep track of the amount of students we add to our list
        public static int Count = 0;
        protected int grade = 2;

        public int Grade
        {
            get => grade;
            set
            {

                if (value == -2 || value == 0 || value == 2 || value == 4 || value == 7 || value == 10 || value == 12)
                {
                    grade = value;

                }
                else
                {
                    Console.WriteLine("value not valid please use 12 grade scale - grade not set\n");
                    // line 28 is a "loop" that will keep continue aslong as we goes into our else block
                    this.Grade = Utility.AskInt("Student grade");
                }
            }
        }

        public Student()
        {

        }

        // A constructor for our Student class, this is so we can add a student hvis we already have the info beforehand
        public Student(string firstName, string lastName, int grade, string cpr, string address, int phoneNumber)
        {
            FirstName = firstName;
            Grade = grade;
            CPR = cpr;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        //Methods
        public void Display()
        {
            Console.WriteLine($"Student name:{FirstName} {LastName} \nStudent grade:{Grade} \nStudent CPR no.:{CPR:##-##-##-####} \nStudent address:{Address} \nStudent phone number:{PhoneNumber}");
            
        }

    }
}

