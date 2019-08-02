using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTrackerCs
{
    class Student:Members
    {
        // This is to keep track of the amount of students we add to our list
        static public int Count = 0;
        protected int grade;
        public int Grade { get => grade; set => grade = value; }

        //Default contructor is needed because we created a constructor for our Student class
        public Student()
        {

        }

        // A constructor for our Student class, this is so we can add a student hvis we already have the info beforehand
        public Student(string name, int grade, long birthday, string address, int phoneNumber)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        //Methods
        public void Display()
        {

            Console.WriteLine($"Student name:{Name} \nStudent grade:{Grade} \nStudent birthday date:{Birthday:##-##-##-####} \nStudent address:{Address} \nStudent phone numer:{PhoneNumber}");
        }

    }
}

