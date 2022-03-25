using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        // variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public long zipCode;
        public long phoneNumber;
        public string email;
        //// constructor that gets user detail and store it in the current object.
        public Contact(string firstName, string lastName, string address, string city, string state, long zipCode, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        /// <summary>
        /// To display the contact details.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("First Name: ", this.firstName);
            Console.WriteLine("Last Name: ", this.lastName);
            Console.WriteLine("Address: ", this.address);
            Console.WriteLine("City: ", this.city);
            Console.WriteLine("State: ", this.state);
            Console.WriteLine("Zipcode: ", this.zipCode);
            Console.WriteLine("phone number: ", this.phoneNumber);
        }
    }
}
