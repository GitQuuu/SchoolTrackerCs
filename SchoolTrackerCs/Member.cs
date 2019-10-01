using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SchoolTrackerCs
{
    class Member
    {
        //fields
        protected string firstName;
        protected string lastName;
        protected string address;
        protected string cpr;
        protected int phoneNumber;
        protected string email;

        //properties
        public string FirstName
        {
            get => firstName;
            set {
                char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                if (!value.Contains(' '))
                {
                    firstName = value;
                }
                else
                {
                    Console.WriteLine("Only firstname please try again if you have more than 1 firstname please use _");
                    this.FirstName = Utility.ExcludeSymbols("Student name", digits);
                }
            }
        }

        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string CPR { get => cpr; set => cpr = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
