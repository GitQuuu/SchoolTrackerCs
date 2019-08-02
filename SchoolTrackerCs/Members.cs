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
        protected long birthday;
        protected int phoneNumber;
        protected string email;

        //properties
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public long Birthday { get => birthday; set => birthday = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
