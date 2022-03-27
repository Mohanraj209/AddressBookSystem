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

            Contact contact = new Contact();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book Program");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Edit Contacts \n 4. Delete Contacts \n 5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email : ");
                        Contact conta = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to be Add: ");
                        AddressBookMain addressBook = new AddressBookMain();
                        Contact cont = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        addressBook.AddContact(cont);
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact details : ");
                        Contact con = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        Console.WriteLine("Enter the Contact Name to be Edited : ");
                        string name = Console.ReadLine();
                        AddressBookMain ab = new AddressBookMain();
                        ab.AddContact(con);
                        ab.EditContact(name);
                        ab.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the contact details :");
                        Contact delete = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        Console.WriteLine("Enter the Contact Name to be deleted : ");
                        string detail = Console.ReadLine();
                        AddressBookMain abook = new AddressBookMain();
                        abook.AddContact(delete);
                        abook.DeleteContact(detail);
                        abook.Display();
                        break;

                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
