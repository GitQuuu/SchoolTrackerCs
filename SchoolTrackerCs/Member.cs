using System;
using System.Collections.Generic;
using System.Text;

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
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string CPR { get => cpr; set => cpr = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
