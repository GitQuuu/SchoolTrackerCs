using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTrackerCs
{
    class Teacher : Members
    {
        static public int Count = 0;

        //fields
        protected decimal salary;
        protected string specials;

        //properties
        public decimal Salary { get => salary; set => salary = value; }
        public string Specials { get => specials; set => specials = value; }

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string cpr, string address, int phoneNumber, decimal salary, string specials)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CPR = cpr;
            PhoneNumber = phoneNumber;
            Salary = salary;
            Specials = specials;
        }

        //Methods
        public void Display()
        {
            Console.WriteLine($"Teacher name:{FirstName}{LastName} \nTeacher salary:{Salary} \nTeacher specials:{Specials} \nTeacher address:{Address} \nTeacher phone number:{PhoneNumber} \nTeacher email:{Email} \nTeacher CPR no.:{CPR} ");
        }
    }
}
