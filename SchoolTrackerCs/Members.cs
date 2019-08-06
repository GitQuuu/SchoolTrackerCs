using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTrackerCs
{
    class Members
    {
        //fields
        protected string name;
        protected string address;
        protected string CPR;
        protected int phoneNumber;
        protected string email;

        //properties
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Birthday { get => CPR; set => CPR = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
