using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("--------** AddressBookSystem **---------");
            Console.Write("\nEnter Contact Details: First Name, Last Name, Address, City, State, Zip, Phone Number, Email ");
            Contactbook addressBook = new Contactbook()  //Initializing elements using collection-initializer syntax
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
            addressBook.DisplayContact();
            Console.ReadLine();
        }
    }
    
}
