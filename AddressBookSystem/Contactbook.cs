using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Contactbook
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zip { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }

        //Method to display Contact.
        public void DisplayContact()
        {
            Console.WriteLine("\nContact Created:");
            Console.WriteLine("\n FirstName: " + this.FirstName + "\n LastName: " + this.LastName
                            + "\n Address: " + this.Address + "\n City: " + this.City + "\n State: "
                            + this.State + "\n Zip: " + this.Zip + "\n PhoneNumber: "
                            + this.PhoneNumber + "\n Email: " + this.Email);
        }

        /// <summary>
        /// This method is used to add new contacts.
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("\nAdd New Contact: ");
            Console.WriteLine("Enter First Name, Last Name, Address, City, State, Zip, Phone Number, Email ");
            Contactbook contactPerson = new Contactbook()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToDouble(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            List<Contactbook> list = new List<Contactbook>();
            list.Add(contactPerson);
            contactPerson.DisplayContact();
        }
    }
}

