using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApps
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string email;
        private string mobile;

        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        
    }
}
