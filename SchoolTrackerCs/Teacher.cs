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

        public Teacher(string name, string birthday, string address, int phoneNumber, decimal salary, string specials)
        {
            Name = name;
            Address = address;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            Salary = salary;
            Specials = specials;
        }

        //Methods
        public void Display()
        {
            Console.WriteLine($"Teacher name:{Name} \nTeacher salary:{Salary} \nTeacher specials:{Specials} \nTeacher address:{Address} \nTeacher phone number:{PhoneNumber} \nTeacher email:{Email} \nTeacher CPR no.:{Birthday} ");
        }
    }
}
